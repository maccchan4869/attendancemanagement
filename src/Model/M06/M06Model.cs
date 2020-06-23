using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.M06
{
    public class CancelVacationModel
    {
        /// <summary>ユーザーID</summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>有給休暇取得日</summary>
        public DateTime VacationDay { get; set; }

        /// <summary>種別CD</summary>
        public string TypeCd { get; set; } = string.Empty;

        /// <summary>更新日時</summary>
        public string UpdateDateTime { get; set; }
    }
}
