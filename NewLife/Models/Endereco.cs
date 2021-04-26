using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLife.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public int CEP { get; set; }
        public string Complemento { get; set; }
        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int ClienteId { get; set; }
        public virtual Clientes Clientes { get; set; }
        public int ProdutosId { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }

    }
}
