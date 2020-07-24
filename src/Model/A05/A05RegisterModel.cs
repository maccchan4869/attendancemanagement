using System;

namespace Model.A05
{
    public class A05RegisterModel
    {
        /// <summary>ユーザーID</summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>休暇取得日</summary>
        public DateTime VacationDay { get; set; }

        /// <summary>承認処理区分</summary>
        public string ApplyStatus { get; set; } = string.Empty;

        /// <summary>更新日時</summary>
        public DateTime UpdateDateTime { get; set; }
    }
}
