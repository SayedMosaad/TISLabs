using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace TISLabs.Domain.Models
{
    public class ApplicationUser : IdentityUser
    {

        public int InternalId { get; set; }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; } = new List<ApplicationUserRole>();
    }

    public class ApplicationRole : IdentityRole<string>
    {
        public ApplicationRole() { }

        public ApplicationRole(string roleName)
            : base(roleName)
        {
        }

        public virtual ICollection<ApplicationUserRole> UserRoles { get; } = new List<ApplicationUserRole>();
    }
    public class ApplicationUserRole : IdentityUserRole<string>
    {

        public ApplicationUser User { get; set; }
        public ApplicationRole Role { get; set; }
    }
    public enum RolesList
    {
        [Display(Name = "Super Admin")]
        SuperAdmin = 1,
        [Display(Name = "Admin")]
        Admin = 2,
    }
}
