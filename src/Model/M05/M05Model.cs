using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Const.Const;

namespace Model.M05
{
    public class ApplyVacationModel
    {
        /// <summary>ユーザーID</summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>有給休暇取得日</summary>
        public DateTime VacationDay { get; set; }

        /// <summary>種別CD</summary>
        public string TypeCd { get; set; } = string.Empty;

        /// <summary>申請状態</summary>
        public string ApplyStatus { get; set; } = APPLY_STATUS.VACATION.APPLYING;

        /// <summary>メモ</summary>
        public string Memo { get; set; } = string.Empty;
    }
}
