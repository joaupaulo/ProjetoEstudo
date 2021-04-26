using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NewLife.Models
{

    [Table("dados_cliente")]
    public class Clientes
    {
        public int Id { get; set; }
        public int Nome { get; set; }

        public int CPF { get; set; }
        public int Credito { get; set; }
        public int Telefone { get; set; }
        public string Status { get; set; }

        public int EnderecoId { get; set; }
        public virtual ICollection<Endereco> Endereco { get; set; }

        public int ProdutosId { get; set; }
        public virtual ICollection<Produtos> Produtos { get; set; }



    }
}
