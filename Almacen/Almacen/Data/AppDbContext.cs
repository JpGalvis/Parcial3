﻿using Almacen.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Almacen.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Producto> Productos { get; set; } 


        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {



        }

    }
}
