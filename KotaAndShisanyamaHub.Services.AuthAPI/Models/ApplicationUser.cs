﻿using Microsoft.AspNetCore.Identity;

namespace KotaAndShisanyamaHub.Services.AuthAPI.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
