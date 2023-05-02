﻿using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MezuniyetSistemi.DataAccess.Concrete.EntityFramework.Contexts
{
    public class MezuniyetSistemiContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=MezuniyetSistemiDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False");
        }

        public MezuniyetSistemiContext(DbContextOptions<MezuniyetSistemiContext> dbContext) : base(dbContext)
        {
            
        }

        public MezuniyetSistemiContext()
        {
            
        }
    }
}