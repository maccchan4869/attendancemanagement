using Model.M05;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Const.Const;

namespace DataAccess.M05
{
    public class M05DataAccess : BaseDataAccess
    {
        public bool RegisterVacation(ApplyVacationModel Model)
        {
            var sql = @"
INSERT INTO tbd_Vacation(
    UserId
    , VacationDay
    , TypeCd
    , ApplyStatus
    , Memo
    , UpdateDateTime
) VALUES ( 
    @UserId
    , @VacationDay
    , @TypeCd
    , @ApplyStatus
    , @Memo
    , @UpdateDateTime
)
";
            var para = new List<SqlParameter>
            {
                new SqlParameter("@UserId", SqlDbType.VarChar) { Value = Model.UserId },
                new SqlParameter("@VacationDay", SqlDbType.Date) { Value = Model.VacationDay },
                new SqlParameter("@TypeCd", SqlDbType.VarChar) { Value = Model.TypeCd },
                new SqlParameter("@ApplyStatus", SqlDbType.VarChar) { Value = Model.ApplyStatus },
                new SqlParameter("@Memo", SqlDbType.VarChar) { Value = Model.Memo },
                new SqlParameter("@UpdateDateTime", SqlDbType.DateTime) { Value = DateTime.Now },
            };
            return DBExecute(sql, para) == 0 ? false : true;
        }
    }
}
