﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Console;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class UserManageDbContext : DbContext
    {

        public UserManageDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        
    }
}
