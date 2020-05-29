using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA_2020
{
    public partial class Servico
    {

        public override string ToString()
        {
            return Valor + "€ " + Unidades + "x" + "[" + Descricao + "]";
        }
    }
}
