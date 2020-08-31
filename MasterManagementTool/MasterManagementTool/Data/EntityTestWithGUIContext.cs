using MasterManagementTool.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Text;
using Microsoft.Data.SqlClient;

namespace MasterManagementTool.Data
{
    public class EntityTestWithGUIContext : DbContext
    {
        public EntityTestWithGUIContext() : base()
        { }

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //System.Diagnostics.Debugger.Launch();
            //ConnectionStringSettings connectionStringSettings = ConfigurationManager.ConnectionStrings["EntityTestWithGUIDB"];
            optionsBuilder.UseSqlServer(
                @"Server=(localdb)\mssqllocaldb;Database=EntityTestWithGUIDB;User ID=sa;Password=password;");
        }
    }
}
