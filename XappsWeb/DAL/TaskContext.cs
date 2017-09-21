using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using XappsWeb.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;


namespace XappsWeb.DAL
{
    public class TaskContext : DbContext
    {
        public DbSet<Task> Tasks { get; set; }

        public TaskContext() : base("TaskContext") { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}