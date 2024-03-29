﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ThePowerRanges.Models;

namespace ThePowerRanges.Models
{
    public class DBContext : DbContext
    {
        public DBContext (DbContextOptions<DBContext> options)
            : base(options)
        {
        }

        public DbSet<ThePowerRanges.Models.User> User { get; set; }

        public DbSet<ThePowerRanges.Models.Budget> Budget { get; set; }
    }
}
