using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ViewModel
{
    public class LoginViewModel
    {
        [Required]
        [Display(Name = "電子メール")]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "パスワード")]
        public string Password { get; set; }

        [Display(Name = "このアカウントを記憶する")]
        public bool RememberMe { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }
}
