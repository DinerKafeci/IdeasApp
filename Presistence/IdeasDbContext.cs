﻿using Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presistence
{
    public class IdeasDbContext : DbContext
    {
        public IdeasDbContext(DbContextOptions<IdeasDbContext> options) : base(options)
        {

        }

        public DbSet<Idea> Ideas { get; set; }
    }
}