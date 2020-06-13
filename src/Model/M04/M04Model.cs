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

        /// <summary>有給休暇申請日</summary>
        public string ApplyDay { get; set; } = string.Empty;

        /// <summary>有給休暇承認日</summary>
        public string ApproveDay { get; set; } = string.Empty;

        /// <summary>有給休暇承認状態</summary>
        public string ApplyStatus { get; set; } = string.Empty;

        /// <summary>有給休暇承認状態CSS</summary>
        public string ApplyStatusCSS { get; set; } = string.Empty;
    }
}
