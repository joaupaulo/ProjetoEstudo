using Microsoft.EntityFrameworkCore;
using NewLife.Configuration;
using NewLife.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLife.Contexto
{
    public class ProjetoContexto : DbContext
    {
        public ProjetoContexto(DbContextOptions<ProjetoContexto> options) : base(options) { }


        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Endereco> Endereco { get; set; }
        public DbSet<Produtos> Produtos { get; set; }
        public DbSet<Status> Status { get; set; }

        internal Task SaveChangesAsync(Clientes clientes)
        {
            throw new NotImplementedException();
        }
    }


    



}
