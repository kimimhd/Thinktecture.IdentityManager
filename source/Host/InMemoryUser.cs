﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Web;

namespace Thinktecture.IdentityManager.Host
{
    public class InMemoryUser
    {
        public InMemoryUser()
        {
            Claims = new HashSet<Claim>();
            Subject = Guid.NewGuid().ToString();
        }

        public string Subject { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Mobile { get; set; }

        public ICollection<Claim> Claims { get; set; }
    }
}