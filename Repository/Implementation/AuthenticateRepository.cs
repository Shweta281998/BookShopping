﻿using ApplicationCore;
using DomainModels.Entites;
using DomainModels.ViewModels;
using Repository.Abstraction;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Implementation
{
    public class AuthenticateRepository : Repository<User>, IAuthenticateRepository
    {
        private DatabaseContext context
        {
            get
            {
                return db as DatabaseContext;
            }
        }
        
        public AuthenticateRepository(DbContext _db) : base(_db)
        {
           
        }
        public UserViewModel ValidateUser(LoginViewModel model)
        {
            User data = context.Users.Include("Roles").Where(u => u.UserName == model.UserName && u.Password ==
            model.Password).FirstOrDefault();
            if(data!=null)
            {
                UserViewModel obj = new UserViewModel
                {
                    UserID = data.UserId,
                    Name = data.UserName,
                    UserName = data.UserName,
                    Address = data.Address,
                    ContactNo = data.contactNo,
                    Roles = data.Roles.Select(r => r.Name).ToArray()
                };
                return obj;
            }
            else
            {
                return null;
            }
           
        }
    }
}
