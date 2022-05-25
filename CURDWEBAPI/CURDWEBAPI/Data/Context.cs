﻿using CURDWEBAPI.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CURDWEBAPI.Data
{
    public class Context :DbContext
    {
        public Context(DbContextOptions<Context> options): base(options)
        {

        }
        public DbSet<Student> students { get; set; }
    }
}
