using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewLife.Models
{
    public class Status
    {

        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Finaliza { get; set; }
        public string Contabiliza { get; set; }
        public int CodigoStatus { get; set; }
        public int ProdutosId { get; set; }
        public virtual Produtos Produtos { get; set; }





    }
}
