using Model.A05;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Const.Const;

namespace DataAccess.Common
{
    public class A05DataAccess : BaseDataAccess
    {
        public SqlDataReader GetReadyInfo()
        {
            var sql = @"
SELECT
    MU.UserId
    , MU.UserName
    , TV.VacationDay
    , TV.TypeCd
    , TV.ApplyStatus
    , TV.Memo
    , MVT.TypeName
    , MAS.StatusName
    , TV.UpdateDateTime
FROM 
    tbd_Vacation AS TV
    INNER JOIN tbm_VacationType AS MVT
        ON TV.TypeCd = MVT.TypeCd
    INNER JOIN tbm_ApplyStatus AS MAS
        ON TV.ApplyStatus = MAS.ApplyStatus
        AND MAS.ApplyCd = @VacationCd
    INNER JOIN tbm_User AS MU
        ON TV.UserId = MU.UserId
";
            var para = new List<SqlParameter>
            {
                new SqlParameter("@VacationCd", SqlDbType.VarChar) { Value = APPLY_CD.VACATION }
            };
            return DBSelect(sql, para);
        }

        public bool Register(A05RegisterModel Model)
        {
            var sql = @"
UPDATE tbd_Vacation
SET
    ApplyStatus = @ApplyStatus
    , UpdateDateTime = @CurrentTime
WHERE
    UserId = @UserId
    AND VacationDay = @VacationDay
    AND UpdateDateTime = @UpdateDateTime
    
";
            var para = new List<SqlParameter>
            {
                new SqlParameter("@UserId", SqlDbType.VarChar) { Value = Model.UserId },
                new SqlParameter("@VacationDay", SqlDbType.Date) { Value = Model.VacationDay },
                new SqlParameter("@ApplyStatus", SqlDbType.VarChar) { Value = Model.ApplyStatus },
                new SqlParameter("@UpdateDateTime", SqlDbType.DateTime) { Value = Model.UpdateDateTime },
                new SqlParameter("@CurrentTime", SqlDbType.DateTime) { Value = DateTime.Now },
            };
            return DBExecute(sql, para) == 0 ? false : true;
        }
    }
}