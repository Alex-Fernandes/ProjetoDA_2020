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
    public partial class FormVenda : Form
    {
        private ModelProjetoContainer container;
        private CasaVendavel casaVendavel;
        private Cliente cliente;

        public FormVenda(CasaVendavel casaVendavel, ModelProjetoContainer container, int estado)
        {
            InitializeComponent();

            this.container = container;
            this.casaVendavel = casaVendavel;

            EstadoAbrir(estado);
            

            comboBox_Comprador.DataSource = null;
            comboBox_Comprador.DataSource = container.Clientes.ToList<Cliente>();
            comboBox_Comprador.Text = " ";
        }

        private void EstadoAbrir(int estado)
        {

            if(estado == 0)
            {
                label_NomeNif.Text = casaVendavel.Proprietario + " ";
                label_ValorBase.Text = casaVendavel.ValorBaseVenda + "";
                label_ComissaoBase.Text = casaVendavel.ValorComissao + "";
            }
            if (estado == 1)
            {
                Venda verVenda = casaVendavel.Venda;
                label_NomeNif.Text = casaVendavel.Proprietario + " ";
                label_ValorBase.Text = casaVendavel.ValorBaseVenda + "";
                label_ComissaoBase.Text = casaVendavel.ValorComissao + "";

                dateTimePicker.Value = verVenda.DataVenda;
                tb_ValorNegociado.Text = verVenda.ValorNegociado.ToString();
                tb_Comissao.Text = verVenda.ComissaoNegociada.ToString();
                comboBox_Comprador.Text = verVenda.Comprador.ToString();

                dateTimePicker.Enabled = false;
                tb_ValorNegociado.Enabled = false;
                tb_Comissao.Enabled = false;
                comboBox_Comprador.Enabled = false;

                btn_Venda.Enabled = false;
            }
        }

        private void btn_Venda_Click(object sender, EventArgs e)
        {
            Venda venda = new Venda();

            venda.DataVenda = dateTimePicker.Value;
            venda.ValorNegociado = Convert.ToDecimal(tb_ValorNegociado.Text);
            venda.ComissaoNegociada = Convert.ToDecimal(tb_Comissao.Text);
            venda.CasaVendavel = casaVendavel;

            cliente.Vendas.Add(venda);
            container.SaveChanges();
        }

        private void comboBox_Comprador_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = null;
            cliente = (Cliente)comboBox_Comprador.SelectedItem;
        }
    }
}
