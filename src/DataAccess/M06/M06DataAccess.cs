using Model.M06;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.M06
{
    public class M06DataAccess : BaseDataAccess
    {
        public bool DeleteVacation(CancelVacationModel Model)
        {
            var sql = @"
DELETE tbd_Vacation
WHERE
        UserId = @UserId
    AND VacationDay = @VacationDay
    AND TypeCd = @TypeCd
    AND UpdateDateTime = @UpdateDateTime
";
            var para = new List<SqlParameter>
            {
                new SqlParameter("@UserId", SqlDbType.VarChar) { Value = Model.UserId },
                new SqlParameter("@VacationDay", SqlDbType.Date) { Value = Model.VacationDay },
                new SqlParameter("@TypeCd", SqlDbType.VarChar) { Value = Model.TypeCd },
                new SqlParameter("@UpdateDateTime", SqlDbType.DateTime) { Value = Model.UpdateDateTime },
            };
            return DBExecute(sql, para) == 0 ? false : true;
        }
    }
}
