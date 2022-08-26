using Data.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Context
{
    public class WarrenContext : DbContext // classe pronta do entity framework para conectar no banco de dados
    {
        #region Props
        public DbSet<Animal> Animal { get; set; } // para conectar o model com tabela do banco / cria tabela
        public DbSet<Planta> Planta { get; set; }

        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) // override de um método pronto do entity framework
        {
            optionsBuilder.UseNpgsql("Host=localhost; Port=5435; Database=postgres; UserId=postgres; Password=123456"); // info para conectar no banco de dados
        }
    }
}
