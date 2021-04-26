using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLife.Models
{
    public class Produtos
    {
        public int Id { get; set; }
        public int Preco { get; set; }
        public int Tipo { get; set; }
        public int CodigoProduto { get; set; }
        public int ClienteId { get; set; }
        public virtual ICollection<Clientes> Clientes { get; set; }
       
        public virtual Endereco Endereco { get; set; }

        public virtual Status Status { get; set; }



    }
}
