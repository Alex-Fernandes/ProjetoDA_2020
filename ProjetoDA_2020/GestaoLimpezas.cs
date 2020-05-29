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
    public partial class GestaoLimpezas : Form
    {
        private ModelProjetoContainer container;
        private CasaVendavel casaVendavel;
        private CasaArrendavel casaArrendavel;
        private Limpeza limpeza;
        private int tipo = 2;

        public GestaoLimpezas(ModelProjetoContainer container, CasaArrendavel casaArrendavel)
        {
            InitializeComponent();

            this.container = container;
            this.casaArrendavel = casaArrendavel;
            tipo = 1;
            label_ValorUnitario.Text = "";
            AtualizarLimpeza();
        }

        public GestaoLimpezas(ModelProjetoContainer container, CasaVendavel casaVenda)
        {
            InitializeComponent();

            this.container = container;
            this.casaVendavel = casaVenda;
            tipo = 0;
            label_ValorUnitario.Text = "";
            AtualizarLimpeza();
        }

        private void btn_Criar_Click(object sender, EventArgs e)
        {
            limpeza = new Limpeza();

            limpeza.Data = dateTimePicker.Value;
            if(tipo == 0)
            {
                limpeza.Casa = casaVendavel;
            }
            if(tipo == 1)
            {
                limpeza.Casa = casaArrendavel;
            }

            container.Limpezas.Add(limpeza);
            container.SaveChanges();

            AtualizarLimpeza();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            Servico servico = new Servico();
            limpeza = (Limpeza)lb_Datas.SelectedItem;

            servico.Descricao = comboBox_Servicos.Text;
            servico.Valor = 10;
            servico.Unidades = Convert.ToInt32(numericUp_Quantidade.Value);
            servico.Limpeza = limpeza;

            container.Servicos.Add(servico);
            container.SaveChanges();
            AtualizarLimpeza();
            AtualizarServico();
        }

        public void AtualizarLimpeza()
        {
            lb_Datas.DataSource = null;

            if(tipo == 1)
            {
                lb_Datas.DataSource = casaArrendavel.Limpezas.ToList<Limpeza>();
            }
            if(tipo == 0)
            {
                lb_Datas.DataSource = casaVendavel.Limpezas.ToList<Limpeza>();
            }
            
        }

        public void AtualizarServico()
        {
            limpeza = (Limpeza)lb_Datas.SelectedItem;
            if(limpeza != null)
            {
                lb_Detalhes.DataSource = null;
                lb_Detalhes.DataSource = limpeza.Servicos.ToList<Servico>();
            }
        }

        private void lb_Datas_SelectedIndexChanged(object sender, EventArgs e)
        {
            AtualizarServico();
        }
    }
}
