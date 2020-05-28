using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoDA_2020
{
    public partial class MenuPrincipal : Form
    {
        private ModelProjetoContainer container;

        public MenuPrincipal()
        {
            InitializeComponent();
            container = new ModelProjetoContainer();
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            GerirClientes gerirClientes = new GerirClientes(container);

            gerirClientes.Show();
        }

        private void btnCasas_Click(object sender, EventArgs e)
        {
            GerirCasas gerirCasas = new GerirCasas(container);
            gerirCasas.Show();
        }
    }
}
