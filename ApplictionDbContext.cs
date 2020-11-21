﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlukInsertcore.Models
{
    public class ApplictionDbContext:DbContext
    {
        public ApplictionDbContext(DbContextOptions<ApplictionDbContext> options)
            : base(options)
        {

        }
        public DbSet<Employee> Employees { get; set; }
    }
}
