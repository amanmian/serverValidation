using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace ServerValidation.Models
{
    public class AuthorContext : DbContext
    {
        public DbSet<User> Users { get; set; }
       
        public AuthorContext() : base("Aman")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Custom");
            base.OnModelCreating(modelBuilder);
        }

    }
}