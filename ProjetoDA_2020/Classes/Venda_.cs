using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA_2020
{
    public partial class Venda
    {

        public override string ToString()
        {
            return "Data: " + DataVenda + " Valor Negociado: " + ValorNegociado + " Comissao: " + ComissaoNegociada;
        }
    }
}
