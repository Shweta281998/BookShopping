﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DomainModels.ViewModels
{
    public class UserViewModel
    {
        public int UserID { get; set; }

        public string UserName { get; set; }

        public string Password { get; set; }

        public string ConfirmPassword { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string ContactNo { get; set; }

        public string[] Roles { get; set; }
    }
}
