﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using EFGettingStarted.Model;

namespace EFGettingStarted.DBContext
{
    class EFContext : DbContext
    {
        public DbSet<User> Users { get; set; }



    }
}
