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
    public partial class FormArrendamentos : Form
    {
        private ModelProjetoContainer container;
        private CasaArrendavel casaArrendavel;
        private Cliente cliente;

        //receber o ModelProjetoContainer e a casaArrendavel
        public FormArrendamentos(ModelProjetoContainer container, CasaArrendavel casaArrendavel)
        {
            InitializeComponent();
            this.container = container;
            this.casaArrendavel = casaArrendavel;

            //popular a combobox
            comboBox_Arrendatario.DataSource = container.Clientes.ToList<Cliente>();

            //inserir nas labels
            label_ID.Text = casaArrendavel.IdCasa + "";
            label_Cliente_Nif.Text = casaArrendavel.Proprietario + "";
            label_Local_Rua_Num_Andar.Text = casaArrendavel.Localidade + " | " + casaArrendavel.Rua
                                            + " | " + casaArrendavel.Numero + " | " + casaArrendavel.Andar;

            LerArrendamentos();
        }

        public void LerArrendamentos()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = casaArrendavel.Arrendamentos.ToList<Arrendamento>();
        }

        private void btn_Inserir_Click(object sender, EventArgs e)
        {
            Arrendamento arrendamento = new Arrendamento();
            arrendamento.InicioContrato = dateTimePicker.Value;
            arrendamento.DuracaoMeses = numericUp_Duracao.Value.ToString();
            arrendamento.Arrendatario = cliente;

            //check box
            if(checkBox_Renovavel.Checked == true)
            {
                arrendamento.Renovavel = "Sim";
            }
            else
            {
                arrendamento.Renovavel = "Não";
            }

            casaArrendavel.Arrendamentos.Add(arrendamento);

            container.SaveChanges();

            MessageBox.Show("Arrendamento Inserido com Sucesso!!!", "Confirmação");

            LerArrendamentos();
        }

        private void btn_Remover_Click(object sender, EventArgs e)
        {
            Arrendamento arrendamento = (Arrendamento)listBox1.SelectedItem;

            DialogResult dialog = MessageBox.Show("Tem a certeza que quer Apagar!", "Apagar o Arrendamento", MessageBoxButtons.YesNo);

            if(dialog == DialogResult.Yes)
            {
                //arrendamento.Arrendatario = null;
                arrendamento.CasaArrendavel = null;

                container.SaveChanges();

                //cliente.Arrendamentos.Remove(arrendamento);
                container.Arrendamentos.Remove(arrendamento);
            }
            if(dialog == DialogResult.No)
            {
                return;
            }
           
            container.SaveChanges();

            LerArrendamentos();
            
        }

        private void comboBox_Arrendatario_SelectedIndexChanged(object sender, EventArgs e)
        {
            cliente = null;
            cliente = (Cliente)comboBox_Arrendatario.SelectedItem;
        }
    }
}
