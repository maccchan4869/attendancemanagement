using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DataAccess
{
    /// <summary>
    /// データアクセスベース
    /// </summary>
    public abstract class BaseDataAccess
    {
        /// <summary>
        /// SELECT文.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        /// <returns></returns>
        public SqlDataReader DBSelect(string sql, List<SqlParameter> param)
        {
            SqlDataReader reader;
            var con = OpenDbConnection();
            using (var command = con.CreateCommand())
            {
                try
                {
                    // データベースの接続開始
                    con.Open();

                    // SQLの設定
                    command.CommandText = sql;
                    foreach (SqlParameter row in param)
                    {
                        command.Parameters.Add(row);
                    }

                    // SQLの実行
                    reader = command.ExecuteReader();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
                return reader;
            }
        }

        /// <summary>
        /// INSERT文.
        /// </summary>
        /// <param name="sql"></param>
        /// <param name="param"></param>
        public int DBInsert(string sql, List<SqlParameter> param)
        {
            var con = OpenDbConnection();
            using (var command = con.CreateCommand())
            {
                try
                {
                    // データベースの接続開始
                    con.Open();

                    // SQLの準備
                    command.CommandText = sql;
                    foreach (SqlParameter row in param)
                    {
                        command.Parameters.Add(row);
                    }

                    // SQLの実行
                    return command.ExecuteNonQuery();
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                    throw;
                }
            }
        }

        /// <summary>
        /// 接続を取得する
        /// </summary>
        /// <param name="dbName"></param>
        /// <returns></returns>
        public static SqlConnection OpenDbConnection(string dbName = "Database")
        {
            var con = new SqlConnection
            {
                ConnectionString = ConfigurationManager.ConnectionStrings[dbName].ConnectionString
            };
            return con;
        }
    }
}
