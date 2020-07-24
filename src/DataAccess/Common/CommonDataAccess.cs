using Model.Common;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Const.Const;

namespace DataAccess.Common
{
    public class CommonDataAccess : BaseDataAccess
    {
        /// <summary>
        /// ユーザー情報を登録
        /// </summary>
        /// <returns></returns>
        public bool RegisterUserInfo(RegisterUserModel Model)
        {
            var sql = @"
INSERT INTO tbm_User(
    UserId
    , UserName
    , MailAddress
    , JoinCompanyDate
    , FirstSupplyHolidays
    , UpdateDateTime
) VALUES ( 
    @UserId
    , @UserName
    , @MailAddress
    , @JoinCompanyDate
    , DATEADD(month, @FirstSupplyHolidays, @JoinCompanyDate)
    , @UpdateDateTime
)
";
            var para = new List<SqlParameter>
            {
                new SqlParameter("@UserId", SqlDbType.VarChar) { Value = Model.UserId },
                new SqlParameter("@UserName", SqlDbType.NVarChar) { Value = Model.UserName },
                new SqlParameter("@MailAddress", SqlDbType.VarChar) { Value = Model.MailAddress },
                new SqlParameter("@JoinCompanyDate", SqlDbType.Date) { Value = Model.JoinCompanyDate },
                new SqlParameter("@FirstSupplyHolidays", SqlDbType.Int) { Value = CONFIG_INT.FIRST_HOLIDAYS },
                new SqlParameter("@UpdateDateTime", SqlDbType.DateTime) { Value = DateTime.Now },
            };
            return DBExecute(sql, para) == 0 ? false : true;
        }
    }
}