﻿using System;
using Microsoft.EntityFrameworkCore;
using taskManagement.Models;
using Task = taskManagement.Models.Task;

namespace taskManagement.Data
{
    public class DbContextClass : DbContext
    {
		protected readonly IConfiguration Configuration;

		public DbContextClass(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
        }

        public DbSet<Workspace> Workspaces { get; set; }
        public DbSet<Board> Boards { get; set; }
        public DbSet<Task> Tasks { get; set; }

    }
}

