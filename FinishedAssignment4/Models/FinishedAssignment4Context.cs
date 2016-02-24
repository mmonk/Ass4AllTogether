using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace FinishedAssignment4.Models
{
    public class FinishedAssignment4Context:DbContext
    {
        public FinishedAssignment4Context() : base("name=FinishedAssignment4Context")
        {
        }

        public System.Data.Entity.DbSet<FinishedAssignment4.Models.Products> Products { get; set; }

        public System.Data.Entity.DbSet<FinishedAssignment4.Models.Orders> Orders { get; set; }

        public System.Data.Entity.DbSet<FinishedAssignment4.Models.OrderDetails> OrderDetails { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
           // modelBuilder.Entity<MenuGroup>().HasOptional(m => m.Menu).WithOptionalDependent().WillCascadeOnDelete(false);

           // modelBuilder.Entity<MenuItem>().HasOptional(m => m.Menu).WithOptionalDependent().WillCascadeOnDelete(false);
           // modelBuilder.Entity<MenuItem>().HasOptional(m => m.MenuGroup).WithOptionalDependent().WillCascadeOnDelete(false);


            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();

            base.OnModelCreating(modelBuilder);
        }

    }
}