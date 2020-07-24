using System;

namespace Model.Common
{
    public class RegisterUserModel
    {
        /// <summary>ユーザーID</summary>
        public string UserId { get; set; } = string.Empty;

        /// <summary>ユーザー名</summary>
        public string UserName { get; set; } = string.Empty;

        /// <summary>メールアドレス</summary>
        public string MailAddress { get; set; } = string.Empty;

        /// <summary>入社年月日</summary>
        public DateTime JoinCompanyDate { get; set; }
    }
}
