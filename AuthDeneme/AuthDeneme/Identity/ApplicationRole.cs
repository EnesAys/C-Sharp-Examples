using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AuthDeneme.Identity
{
    public class ApplicationRole: IdentityRole
    {
        public string RoleDescription { get; set; }
        public ApplicationRole()
        {

        }
        public ApplicationRole(string roleName,string description):base(roleName)
        {
            this.RoleDescription = description;
        }
    }
}