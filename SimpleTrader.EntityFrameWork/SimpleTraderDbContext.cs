using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using SimpleTrader.Domain.Models;

namespace SimpleTrader.EntityFrameWork
{
    class SimpleTraderDbContext : DbContext //store data
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Account> Accounts { get; set; }
        public DbSet<AssetTransaction> AssetTransactions { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().ToTable("User");
            modelBuilder.Entity<User>().Property(c => c.Id);

            base.OnModelCreating(modelBuilder);
        }
    }
}
