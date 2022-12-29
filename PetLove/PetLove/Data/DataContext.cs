﻿using Microsoft.EntityFrameworkCore;
using PetLove.Data.Entities;

namespace PetLove.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }
        public DbSet<Cliente> Clientes { get; set; }
    }

}
