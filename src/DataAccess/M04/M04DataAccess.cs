using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using static Const.Const;

namespace DataAccess.M04
{
    public class M04DataAccess : BaseDataAccess
    {
        public SqlDataReader GetReadyInfo(string UserId)
        {
            var sql = @"
SELECT
    TV.VacationDay
    , TV.TypeCd
    , TV.ApplyStatus
    , TV.Memo
    , MVT.TypeName
    , StatusName
FROM 
    tbd_Vacation AS TV
    INNER JOIN tbm_VacationType AS MVT
        ON TV.TypeCd = MVT.TypeCd
    INNER JOIN tbm_ApplyStatus AS MAS
        ON TV.ApplyStatus = MAS.ApplyStatus
        AND MAS.ApplyCd = @VacationCd
WHERE
    TV.UserId = @UserId
";
            var para = new List<SqlParameter>
            {
                new SqlParameter("@UserId", SqlDbType.VarChar) { Value = UserId },
                new SqlParameter("@VacationCd", SqlDbType.VarChar) { Value = APPLY_CD.VACATION },
            };
            return DBSelect(sql, para);
        }

        public SqlDataReader GetDorpDownList()
        {
            var sql = @"
SELECT
    TypeCd
    , TypeName
FROM 
    tbm_VacationType
";
            var para = new List<SqlParameter>();
            return DBSelect(sql, para);
        }
    }
}