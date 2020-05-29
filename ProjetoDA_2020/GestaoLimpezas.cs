using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
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

        //tipo para diferenciar de casaVendavel e Arrendada
        private int tipo = 2;

        //dois construtores um a receber casaArrendavel
        public GestaoLimpezas(ModelProjetoContainer container, CasaArrendavel casaArrendavel)
        {
            InitializeComponent();

            //recebe o ModelProjetoContainer
            this.container = container;
            //recebe a casaArrendavel
            this.casaArrendavel = casaArrendavel;

            tipo = 1;
            label_ValorUnitario.Text = "10";
            AtualizarLimpeza();
        }

        //e o outro a receber casaVendida
        public GestaoLimpezas(ModelProjetoContainer container, CasaVendavel casaVenda)
        {
            InitializeComponent();

            //recebe o ModelProjetoContainer
            this.container = container;
            //recebe a casaArrendavel
            this.casaVendavel = casaVenda;
            tipo = 0;
            label_ValorUnitario.Text = "10";
            AtualizarLimpeza();
        }


        //Criar nova limpeza
        private void btn_Criar_Click(object sender, EventArgs e)
        {
            limpeza = new Limpeza();

            limpeza.Data = dateTimePicker.Value;

            //diferenciar entre os tipos de casas
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

        //novo servico
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

            //diferenciar os tipos de casas
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

        //faturas
        private void btn_EmitirFaturas_Click(object sender, EventArgs e)
        {
            //verificar se está algo selecionado
            if(lb_Datas.SelectedIndex == -1)
            {
                return;
            }

            limpeza = (Limpeza)lb_Datas.SelectedItem;

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            if(saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter writer = new StreamWriter(saveFileDialog.OpenFile());
                writer.WriteLine("Recibo Limpeza:");
                writer.WriteLine("--------------------------------------------");
                //separar pelo tipo de casa

                //casaArrendavel
                if(tipo == 1)
                {
                    writer.WriteLine(casaArrendavel.Proprietario);
                    writer.WriteLine("Às " + DateTime.Now);
                    writer.WriteLine("");
                    writer.WriteLine("Serviços: ");
                    writer.WriteLine("--------------------------------------------");

                    foreach (Limpeza limpeza in casaArrendavel.Limpezas)
                    {
                        writer.WriteLine(limpeza);
                        foreach (Servico servico in limpeza.Servicos)
                        {
                            writer.WriteLine(" - " + servico);
                        }
                    }

                }

                //casaVendavel
                if (tipo == 0)
                {
                    writer.WriteLine(casaVendavel.Proprietario);

                    writer.WriteLine("");
                    writer.WriteLine("Serviços: ");
                    writer.WriteLine("--------------------------------------------");

                    foreach (Limpeza limpeza in casaVendavel.Limpezas)
                    {
                        writer.WriteLine(limpeza);
                        foreach (Servico servico in limpeza.Servicos)
                        {
                            writer.WriteLine(" - " + servico);
                        }
                    }

                }

                writer.Flush();
                writer.Close();
            }
        }
    }
}
/* 
 * criacao base de dados 
 * fazer em ficheiros diferentes
 * 1 criacao de tabelas
 * 2 introduzcao de dados
 * 3 consultas
 * 4 criacao de utilizadores
 * 
 * -*/
