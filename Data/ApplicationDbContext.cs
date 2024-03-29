﻿using APIClientes.Models;
using Microsoft.EntityFrameworkCore;

namespace APIClientes.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options)
        {
            
        }

        public DbSet<Client> Clients { get; set; }

    }
}
