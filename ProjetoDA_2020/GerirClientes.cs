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
    public partial class GerirClientes : Form
    {

        private ModelProjetoContainer container;

        public GerirClientes(ModelProjetoContainer container)
        {
            InitializeComponent();
            this.container = container;

        }

        private void GerirClientes_Load(object sender, EventArgs e)
        {
            container = new ModelProjetoContainer();
            LerDados();
        }

        public void LerDados()
        {
            clienteDataGridView.DataSource = container.Clientes.ToList<Cliente>();
        }

        public void AtualizarArrendamentos()
        {
            Cliente cliente = (Cliente)clienteDataGridView.SelectedRows[0].DataBoundItem;
            lbArrendamentos.DataSource = null;
            lbArrendamentos.DataSource = cliente.Arrendamentos.ToList<Arrendamento>();
        }

        public void AtualizarAquisicoes()
        {
            Cliente cliente = (Cliente)clienteDataGridView.SelectedRows[0].DataBoundItem;
            lbAquisicoes.DataSource = null;
            lbAquisicoes.DataSource = cliente.Vendas.ToList<Venda>();
        }

        public void AtualizarCasas()
        {
            Cliente cliente = (Cliente)clienteDataGridView.SelectedRows[0].DataBoundItem;
            lbCasas.DataSource = null;
            lbCasas.DataSource = cliente.Casas.ToList<Casa>();
        }

        //Novo Cliente
        private void Button2_Click(object sender, EventArgs e)
        {
            string nome = nomeTextBox.Text;
            string nif = nIFTextBox.Text;
            string morada = moradaTextBox.Text;
            string contacto = contactoTextBox.Text;

            if(nome.Length == 0)
            {
                MessageBox.Show("Preencha o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nif.Length == 0)
            {
                MessageBox.Show("Preencha o nif", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (morada.Length == 0)
            {
                MessageBox.Show("Preencha o morada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contacto.Length == 0)
            {
                MessageBox.Show("Preencha o contacto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Cliente cliente = new Cliente();

            cliente.Nome = nome;
            cliente.NIF = nif;
            cliente.Morada = morada;
            cliente.Contacto = contacto;

            container.Clientes.Add(cliente);

            container.SaveChanges();

            LerDados();

            nomeTextBox.Text = " ";
            nIFTextBox.Text = " ";
            moradaTextBox.Text = " ";
            contactoTextBox.Text = " ";

        }

        
        //Apagar
        private void button4_Click(object sender, EventArgs e)
        {
            if (clienteDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            Cliente clienteSelecionado = (Cliente)clienteDataGridView.SelectedRows[0].DataBoundItem;
            container.Clientes.Remove(clienteSelecionado);
            container.SaveChanges();

            LerDados();
        } 

        //Filtrar
        private void button1_Click(object sender, EventArgs e)
        {
            string procurar = tb_Filtrar.Text;
            int indice = cb_Filtro.SelectedIndex;
            int rowIndex = 0;

            ////fazer com que ao abrir nao houvesse nada selecionado
            clienteDataGridView.Rows[0].Selected = false;

            try
            {
                //para verificar que nao foi encontrado nenhum resultado
                bool verificar = false;

                //procurar na datadgrid
                foreach(DataGridViewRow row in clienteDataGridView.Rows)
                {
                    //se em um dos (Nome, NIF, Morada, Conctato, existe o que se está a procurar)
                    if (row.Cells[indice].Value.ToString().ToUpper().Equals(procurar.ToUpper()))
                    {
                        rowIndex = row.Index;
                        //selecionar a row onde foi encontrado a procura
                        clienteDataGridView.Rows[rowIndex].Selected = true;
                        verificar = true;
                        break;
                    }
                }
                if (verificar == false)
                {
                    MessageBox.Show("Procura: " + procurar + " não encontrado!");
                }

                //criar DataGridViewCellEventArgs com o row 
                DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, rowIndex);
                //chamar o cell click para clicar no row apontado em cima
                clienteDataGridView_CellClick(clienteDataGridView, args);

            }
            catch(Exception ex)
            {
                return;
                //MessageBox.Show("Erro Filtrar: " + ex.Message);
            }
        }


        //Alterar / Guardar 
        private void button3_Click(object sender, EventArgs e)
        {
            string nome = nomeTextBox.Text;
            string nif = nIFTextBox.Text;
            string morada = moradaTextBox.Text;
            string contacto = contactoTextBox.Text;

            if (nome.Length == 0)
            {
                MessageBox.Show("Preencha o nome", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (nif.Length == 0)
            {
                MessageBox.Show("Preencha o nif", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (morada.Length == 0)
            {
                MessageBox.Show("Preencha o morada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (contacto.Length == 0)
            {
                MessageBox.Show("Preencha o contacto", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
            Cliente clienteSelecionado = (Cliente)clienteDataGridView.SelectedRows[0].DataBoundItem;

            clienteSelecionado.Nome = nome;
            clienteSelecionado.NIF = nif;
            clienteSelecionado.Morada = morada;
            clienteSelecionado.Contacto = contacto;
            
            container.SaveChanges();

            LerDados();

            nomeTextBox.Text = " ";
            nIFTextBox.Text = " ";
            moradaTextBox.Text = " ";
            contactoTextBox.Text = " ";
        }

        //Apagar textbox
        private void btn_Clear_Click(object sender, EventArgs e)
        {
            nomeTextBox.Text = "";
            nIFTextBox.Text = "";
            moradaTextBox.Text = "";
            contactoTextBox.Text = "";

            lbCasas.DataSource = null;
        }

        //ao clicar preenche os campos
        private void clienteDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            Cliente cliente = (Cliente)clienteDataGridView.SelectedRows[0].DataBoundItem;
            nomeTextBox.Text = cliente.Nome;
            nIFTextBox.Text = cliente.NIF;
            moradaTextBox.Text = cliente.Morada;
            contactoTextBox.Text = cliente.Contacto;

            AtualizarCasas();
            AtualizarAquisicoes();
            //AtualizarArrendamentos();

            //util para descobrir a posicao expecifica na datagrid
            /*
            if (clienteDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
            {
                MessageBox.Show(clienteDataGridView.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString() + " " + e.RowIndex + " " + e.ColumnIndex);
            }*/
        }

        //Click para abrir em casas
        private void lbCasas_DoubleClick(object sender, EventArgs e)
        {
            int num = 0;

            GerirCasas gerirCasas = new GerirCasas(container);
            Casa casa = (Casa)lbCasas.SelectedItem;

            num = casa.IdCasa;
            gerirCasas.Show();
            gerirCasas.ClienteToCasas(num);

            this.Close();
            
        }


    }
}
