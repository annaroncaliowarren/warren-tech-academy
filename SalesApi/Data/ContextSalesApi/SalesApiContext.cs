using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.ContextSalesApi
{
    public class SalesApiContext : DbContext
    {
        #region Props
        public DbSet<ProductModel> Product_tb { get; set; }
        public DbSet<ClientModel> Client_tb { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5433; Database=postgres; UserId=postgres; Password=123456");
        }
    }
}
