﻿using Microsoft.EntityFrameworkCore;
using PrimerParcialAplicada2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PrimerParcialAplicada2.DAL
{
    public class Contexto : DbContext

    {
        public DbSet <Articulos> Articulos  { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite(@"DATA\Parcial1.db");
        }
    }
}
