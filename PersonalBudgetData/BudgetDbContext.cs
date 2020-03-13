using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalBudgetData
{
    public class BudgetDbContext : DbContext
    {
        public BudgetDbContext() : base("DefaultConnection")
        {

        }
        public static BudgetDbContext Create()
        {
            return new BudgetDbContext();
        }
        public DbSet<Transaction> Transactions { get; set; }

        //Probably don't need this:
        //protected override void OnModelCreating(DbModelBuilder modelBuilder)
        //{
        //    modelBuilder
        //        .Conventions.Remove<PluralizingTableNameConvention>();

        //    modelBuilder
        //        .Configurations
        //        .Add(new IdentityUserLoginConfiguration())
        //        .Add(new IdentityUserRoleConfiguration());
        //}
    }
}
