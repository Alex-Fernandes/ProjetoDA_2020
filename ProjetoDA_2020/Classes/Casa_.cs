using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA_2020
{
    public partial class Casa
    {
        

        public override string ToString()
        {
            //Vendavel alterar no futuro?
            return "Vendável: " + IdCasa + " - " + Localidade + " - " + Rua;
        }
    }
}
