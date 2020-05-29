using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA_2020
{
    public partial class Limpeza
    {

        public decimal Total
        {
            get
            {
                Decimal temp = 0;
                foreach (Servico item in Servicos)
                {
                    temp += item.Valor;
                }
                return temp;
            }
        }


        public override string ToString()
        {
            return Total + "€ a " + Data;
        }
    }
}
