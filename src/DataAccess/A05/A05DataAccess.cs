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
    TV.VacationDay
    , TV.TypeCd
    , TV.ApplyStatus
    , TV.Memo
    , MVT.TypeName
    , StatusName
    , TV.UpdateDateTime
FROM 
    tbd_Vacation AS TV
    INNER JOIN tbm_VacationType AS MVT
        ON TV.TypeCd = MVT.TypeCd
    INNER JOIN tbm_ApplyStatus AS MAS
        ON TV.ApplyStatus = MAS.ApplyStatus
        AND MAS.ApplyCd = @VacationCd
";
            var para = new List<SqlParameter>
            {
                new SqlParameter("@VacationCd", SqlDbType.VarChar) { Value = APPLY_CD.VACATION }
            };
            return DBSelect(sql, para);
        }
    }
}