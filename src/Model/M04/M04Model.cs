using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.M04
{
    public class M04VacationModel
    {
        /// <summary>有給休暇取得日</summary>
        public string VacationDay { get; set; } = string.Empty;

        /// <summary>種別CD</summary>
        public string TypeCd { get; set; } = string.Empty;

        /// <summary>種別名</summary>
        public string TypeName { get; set; } = string.Empty;

        /// <summary>申請状態</summary>
        public string ApplyStatus { get; set; } = string.Empty;

        /// <summary>申請状態名</summary>
        public string StatusName { get; set; } = string.Empty;

        /// <summary>有給休暇承認状態CSS</summary>
        public string ApplyStatusCSS { get; set; } = string.Empty;

        /// <summary>メモ</summary>
        public string Memo { get; set; } = string.Empty;
    }
}
