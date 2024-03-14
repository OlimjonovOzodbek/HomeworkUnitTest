﻿using MarketPlace.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarketPlace.Infrastructure.Persistance
{
    public class DbContextt : DbContext
    {
        public DbContextt(DbContextOptions<DbContextt> ops)
            : base(ops)
            => Database.Migrate();

        public DbSet<Product> Products { get; set; }
    }
}
