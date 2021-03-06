﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebsiteForAds.Models
{
    public class ExternalLoginConfirmationViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class ExternalLoginListViewModel
    {
        public string ReturnUrl { get; set; }
    }

    public class SendCodeViewModel
    {
        public string SelectedProvider { get; set; }
        public ICollection<System.Web.Mvc.SelectListItem> Providers { get; set; }
        public string ReturnUrl { get; set; }
        public bool RememberMe { get; set; }
    }

    public class VerifyCodeViewModel
    {
        [Required]
        public string Provider { get; set; }

        [Required]
        [Display(Name = "Code")]
        public string Code { get; set; }
        public string ReturnUrl { get; set; }

        [Display(Name = "Remember this browser?")]
        public bool RememberBrowser { get; set; }

        public bool RememberMe { get; set; }
    }

    public class ForgotViewModel
    {
        [Required]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }

    public class LoginViewModel
    {
        [Required(ErrorMessage = "Потребителското име е задължително")]
        [Display(Name = "Потребителско име:")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна")]
        [DataType(DataType.Password)]
        [Display(Name = "Парола:")]
        public string Password { get; set; }

        [Display(Name = "Запомни ме?")]
        public bool RememberMe { get; set; }
    }

    public class RegisterViewModel
    {
        [Required(ErrorMessage = "Името и презимето са задължителни")]
        [Display(Name = "Име и презиме:")]
        public string FullName { get; set; }

        [Required(ErrorMessage = "Потребителското име е задължително")]
        [Display(Name = "Потребителско име:")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Имейла е задължителен")]
        [EmailAddress]
        [StringLength(100, ErrorMessage = "{0} трябва да бъде поне {2} символа.", MinimumLength = 1)]
        [Display(Name = "Имейл:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна")]
        [StringLength(100, ErrorMessage = "{0} трябва да бъде поне {2} символа.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола:")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Паролата за потвърждине е задължителна")]
        [DataType(DataType.Password)]
        [Display(Name = "Потвърди паролата:")]
        [Compare("Password", ErrorMessage = "Паролите не съвпадат.")]
        public string ConfirmPassword { get; set; }
    }

    public class ResetPasswordViewModel
    {
        [Required(ErrorMessage = "Имейла е задължителен")]
        [EmailAddress]
        [Display(Name = "Имейл:")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Паролата е задължителна")]
        [StringLength(100, ErrorMessage = "Полето \"{0}\" трябва да бъде поне {2} символа.", MinimumLength = 1)]
        [DataType(DataType.Password)]
        [Display(Name = "Парола:")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Потъврди паролата:")]
        [Compare("Password", ErrorMessage = "Паролите не съвпадат.")]
        public string ConfirmPassword { get; set; }

        public string Code { get; set; }
    }

    public class ForgotPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [Display(Name = "Email")]
        public string Email { get; set; }
    }
}
