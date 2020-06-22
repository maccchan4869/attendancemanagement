using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Const.Const;

namespace Model.Common
{
    public class ResultModel
    {
        /// <summary>結果コード</summary>
        public string ResultCd { get; set; } = RESULT_CD.SUCCESS;

        /// <summary>エラーメッセージ</summary>
        public string ErrorMessage { get; set; } = string.Empty;
    }
}
