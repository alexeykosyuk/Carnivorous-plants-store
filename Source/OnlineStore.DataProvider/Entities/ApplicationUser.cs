﻿using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.DataProvider.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public virtual ApplicationUserProfile ApplicationUserProfile { get; set; }

        public virtual Administrator Administrator { get; set; }

        public virtual Customer Customer { get; set; }

        public virtual Manager Manager { get; set; }

        public virtual Owner Owner { get; set; }

        [ForeignKey("Language")]
        public string LanguageId { get; set; }
        public virtual Language Language { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            return userIdentity;
        }
    }
}
