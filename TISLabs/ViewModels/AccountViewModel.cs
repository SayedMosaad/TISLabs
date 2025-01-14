using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Security.Claims;
using TISLabs.Domain.Models;

namespace TISLabs.ViewModels
{
    public class LoginViewModel
    {
        [Required]

        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "Remember me")]
        public bool RememberMe { get; set; }
    }
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        //[Remote(action: "IsEmailInUse", controller: "Account")]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [MinLength(3)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("Password",
            ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }

        [Required]
        public int InternalId { get; set; }

        [Required]
        [Display(Name = "Role")]
        public List<string> Roles { get; set; }
        public string Name { get; set; }
    }
    public class EditUserVM
    {
        public EditUserVM()
        {
            Roles = new List<string>();
            Claims = new List<string>();
        }
        public string Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required, EmailAddress]
        public string Email { get; set; }
        public string Name { get; set; }
        public int InternalId { get; set; }
        public List<string> Roles { get; set; }
        public List<string> Claims { get; set; }
    }
    public class RoleViewModel
    {
        public string Id { get; set; }
        [Required]
        [Display(Name = "Name")]
        public RolesList Name { get; set; }
    }

    public class ChangePasswordViewModel
    {
        public string Id { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }

        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "New Password")]
        public string NewPassword { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "Confirm password")]
        [Compare("NewPassword", ErrorMessage = "Password and confirmation password do not match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ChangePasswordVM
    {
        [Required]
        public string Id { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Current Password")]
        public string CurrentPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "New Password")]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Confirm Password"),
         Compare("NewPassword", ErrorMessage = "Password and Confirmation Password Does Not Match.")]
        public string ConfirmPassword { get; set; }
    }
    public class ForgetPasswordVM
    {
        [Required]
        public string Id { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "New Password")]
        public string NewPassword { get; set; }
        [Required, DataType(DataType.Password), Display(Name = "Confirm Password"),
         Compare("NewPassword", ErrorMessage = "Password and Confirmation Password Does Not Match.")]
        public string ConfirmPassword { get; set; }
    }
    public class UserRolesVM
    {
        public string RoleId { get; set; }
        public string RoleName { get; set; }
        public bool IsSelected { get; set; }

    }
    public class UserClaimsVM
    {
        public UserClaimsVM()
        {
            Claims = new List<UserClaim>();
        }
        public string UserId { get; set; }
        public List<UserClaim> Claims { get; set; }

    }
    public class UserClaim
    {
        public string Id { get; set; }
        public string ClaimType { get; set; }
        public bool IsSelected { get; set; }

    }

    public static class ClaimsStore
    {
        public static List<Claim> AllClaims = new List<Claim>()
        {
            new Claim("Create Role","Create Role"),
            new Claim("Edit Role","Edit Role"),
            new Claim("Delete Role","Delete Role"),
            new Claim("Report","Report"),

        };
    }
}
