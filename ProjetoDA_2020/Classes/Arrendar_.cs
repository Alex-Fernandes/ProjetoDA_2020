using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoDA_2020
{
    public partial class Arrendamento
    {

        public override string ToString()
        {
            return "Inicio: " + InicioContrato + " Duração: " + DuracaoMeses + " Renovavel: " + Renovavel;
        }
    }
}
