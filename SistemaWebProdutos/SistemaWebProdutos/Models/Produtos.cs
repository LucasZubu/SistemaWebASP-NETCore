using System;
using System.Collections.Generic;

namespace SistemaWebProdutos.Models
{
    public partial class Produtos
    {
        public int ProdCod { get; set; }
        public string ProdNome { get; set; }
        public decimal ProdPreco { get; set; }
        public int ProdQntd { get; set; }
    }
}
