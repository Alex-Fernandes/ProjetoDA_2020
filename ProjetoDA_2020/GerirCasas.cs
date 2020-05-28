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
    public partial class GerirCasas : Form
    {
        private ModelProjetoContainer container;


        public int GetID;

        public GerirCasas(ModelProjetoContainer container)
        {
            InitializeComponent();
            this.container = container;
           
        }

        private void GerirCasas_Load(object sender, EventArgs e)
        {
           
            gb_Arrendavel.Enabled = false;
            gb_Venda.Enabled = false;
            container = new ModelProjetoContainer();

            //carregar utilizadores para a combobox
            cb_Proprietario.DataSource = container.Clientes.ToList<Cliente>();
            cb_Proprietario.Text = "";
            //atualizar casas
            LerCasas();
        }

        public void LerCasas()
        {
           casaDataGridView.DataSource = container.Casas.ToList<Casa>();
        }

        //Funcao executada a partir dos clientes
        public void ClienteToCasas(int idCasa)
        {
            LerCasas();
            //fazer com que ao abrir nao houvesse nada selecionado
            casaDataGridView.Rows[0].Selected = false;
            
            this.GetID = idCasa;
            
            //-1 pq nao existe nenhuma posicao -1 na datagrid
            int rowIndex = -1;
            
            //pesquisar pela datagrid 
            foreach (DataGridViewRow row in casaDataGridView.Rows)
            {
                //se na row.Cells[0].Value existir o id da casa selecionada pelo cliente anteriormente
                if (row.Cells[0].Value.ToString().Equals(GetID.ToString()))
                {
                    //row index fica com a posicao na row
                    rowIndex = row.Index;
                    break;

                }
            }

            //selecionar na datagrid o row com o valor rowIndex
            casaDataGridView.Rows[rowIndex].Selected = true;
            //criar DataGridViewCellEventArgs com o row 
            DataGridViewCellEventArgs args = new DataGridViewCellEventArgs(0, rowIndex);
            //chamar o cell click para clicar no row apontado em cima
            casaDataGridView_CellClick(casaDataGridView, args);
        }

        //Apagar
        private void btn_Apagar_Click(object sender, EventArgs e)
        {
            if (casaDataGridView.SelectedRows.Count == 0)
            {
                return;
            }

            int resposta = 2;

            resposta = checkTypeCasa();

            CasaArrendavel casaArrendavel;
            CasaVendavel casaVendavel;
            Casa casa = (Casa)casaDataGridView.SelectedRows[0].DataBoundItem;
            
            if(resposta == 1)
            {
                
                casaArrendavel = (CasaArrendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                casaArrendavel.Arrendamentos = null;
                casaArrendavel.Proprietario = null;
                container.Casas.Remove(casaArrendavel);
            }
            if(resposta == 0)
            {
                casaVendavel = (CasaVendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                casaVendavel.Venda = null;
                casaVendavel.Proprietario = null;
                container.Casas.Remove(casaVendavel);
            }
            if(resposta == -1)
            {
                return;
            }
            
            
            //container.Casas.Remove(casa);
            container.SaveChanges();

            LerCasas();
        }

        //guardar - alterar
        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            string localidade = tb_Localidade.Text;
            string rua = tb_Rua.Text;
            string numero = tb_Numero.Text;
            string andar = tb_Andar.Text;

            int area = Convert.ToInt32(Math.Round(numUp_Area.Value, 0));
            int assoalhadas = Convert.ToInt32(Math.Round(numUp_Assoalhadas.Value, 0));
            int wc = Convert.ToInt32(Math.Round(numUp_WC.Value, 0));
            int pisos = Convert.ToInt32(Math.Round(numUp_Pisos.Value, 0));

            string tipo = cb_Tipo.Text;
            string proprietario = cb_Proprietario.Text;

            if (localidade.Length == 0)
            {
                MessageBox.Show("Preencha a Localidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rua.Length == 0)
            {
                MessageBox.Show("Preencha a Rua", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numero.Length == 0)
            {
                MessageBox.Show("Preencha o Numero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (andar.Length == 0)
            {
                MessageBox.Show("Preencha o Andar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (area == 0)
            {
                MessageBox.Show("Preencha a Area", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (assoalhadas == 0)
            {
                MessageBox.Show("Preencha a Assoalhada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (wc == 0)
            {
                MessageBox.Show("Preencha a WC", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pisos == 0)
            {
                MessageBox.Show("Preencha os Pisos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tipo.Length == 0)
            {
                MessageBox.Show("Selecione o Tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (proprietario.Length == 0)
            {
                MessageBox.Show("Selecione o Proprietario", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            Casa casaSelecionada = (Casa)casaDataGridView.SelectedRows[0].DataBoundItem;

            casaSelecionada.Localidade = localidade;
            casaSelecionada.Rua = rua;
            casaSelecionada.Numero = numero;
            casaSelecionada.Andar = andar;
            casaSelecionada.Area = area;
            casaSelecionada.NumeroAssoalhada = assoalhadas;
            casaSelecionada.NumeroWC = wc;
            casaSelecionada.NumeroPisos = pisos;
            casaSelecionada.Tipo = tipo;
            casaSelecionada.Proprietario = (Cliente)cb_Proprietario.SelectedItem;

            container.SaveChanges();
            LerCasas();
            
        }

        //nLimpar
        private void btn_Nova_Click(object sender, EventArgs e)
        {
            casaDataGridView.CurrentCell = null;

            labelI_ID.Text = "";
            tb_Localidade.Text = "";
            tb_Rua.Text = "";
            tb_Numero.Text = "";
            tb_Andar.Text = "";

            numUp_Area.Value = 1;
            numUp_Assoalhadas.Value = 1;
            numUp_WC.Value = 1;
            numUp_Pisos.Value = 1;

            cb_Tipo.Text = "";
            cb_Proprietario.Text = "";
        }

        //ao clicar preenche os campos
        private void casaDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Casa casa = (Casa)casaDataGridView.SelectedRows[0].DataBoundItem;
            Cliente cliente = casa.Proprietario;
            CasaArrendavel casaArrendavel;
            CasaVendavel casaVendavel;
           
            labelI_ID.Text = casa.IdCasa.ToString();
            tb_Localidade.Text = casa.Localidade.ToString();
            tb_Rua.Text = casa.Rua.ToString();
            tb_Numero.Text = casa.Numero.ToString();
            tb_Andar.Text = casa.Andar.ToString();

            numUp_Area.Value = Convert.ToInt32(casa.Area.ToString());
            numUp_Assoalhadas.Value = Convert.ToInt32(casa.NumeroAssoalhada.ToString());
            numUp_WC.Value = Convert.ToInt32(casa.NumeroWC.ToString());
            numUp_Pisos.Value = Convert.ToInt32(casa.NumeroPisos.ToString());

            cb_Tipo.Text = casa.Tipo.ToString();
            cb_Proprietario.Text = casa.Proprietario.ToString();

            try
            {
                try
                {
                    casaArrendavel = (CasaArrendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                    if (casa.IdCasa == casaArrendavel.IdCasa)
                    {
                        checkArrendavel.Checked = true;
                        tb_ValorBase.Text = casaArrendavel.ValorBaseMes.ToString();
                        tb_Comissao.Text = casaArrendavel.Comissao.ToString(); 
                        //MessageBox.Show("Arrendavel");
                    }
                }
                catch (Exception exx)
                {
                    //MessageBox.Show("Erro: CasaArrendavel " + exx.Message);
                }
                try
                {
                    casaVendavel = (CasaVendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                    if (casa.IdCasa == casaVendavel.IdCasa)
                    {
                        checkVendavel.Checked = true;
                        tb_ValorNegociavel_Venda.Text = casaVendavel.ValorBaseVenda.ToString();
                        tb_ComissaoBase_Venda.Text = casaVendavel.ValorBaseVenda.ToString();
                        //MessageBox.Show("Vendavel");
                    }
                }
                catch (Exception exxx)
                {
                    //MessageBox.Show("Erro CasaVendavel: " + exxx.Message);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        //Check boxes Casa Arrendavel
        private void checkArrendavel_CheckedChanged(object sender, EventArgs e)
        {
            if(checkArrendavel.Checked == true)
            {
                gb_Arrendavel.Enabled = true;
                gb_Venda.Enabled = false;
                checkVendavel.Checked = false;
            }

            if(checkArrendavel.Checked == false)
            {
                gb_Arrendavel.Enabled = false;
            }
        }

        //Criar Casa Arrendavel
        private void btn_VerCriar_Arrendamento_Click(object sender, EventArgs e)
        {
            decimal valorBaseMes, comissao;
            string localidade = tb_Localidade.Text;
            string rua = tb_Rua.Text;
            string numero = tb_Numero.Text;
            string andar = tb_Andar.Text;

            int area = Convert.ToInt32(Math.Round(numUp_Area.Value, 0));
            int assoalhadas = Convert.ToInt32(Math.Round(numUp_Assoalhadas.Value, 0));
            int wc = Convert.ToInt32(Math.Round(numUp_WC.Value, 0));
            int pisos = Convert.ToInt32(Math.Round(numUp_Pisos.Value, 0));

            string tipo = cb_Tipo.Text;

            int resultado = 2;

            //convercoes
            decimal.TryParse(tb_ValorBase.Text, out valorBaseMes);
            decimal.TryParse(tb_Comissao.Text, out comissao);

            if (localidade.Length == 0)
            {
                MessageBox.Show("Preencha a Localidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rua.Length == 0)
            {
                MessageBox.Show("Preencha a Rua", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numero.Length == 0)
            {
                MessageBox.Show("Preencha o Numero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (andar.Length == 0)
            {
                MessageBox.Show("Preencha o Andar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (area == 0)
            {
                MessageBox.Show("Preencha a Area", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (assoalhadas == 0)
            {
                MessageBox.Show("Preencha a Assoalhada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (wc == 0)
            {
                MessageBox.Show("Preencha a WC", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pisos == 0)
            {
                MessageBox.Show("Preencha os Pisos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tipo.Length == 0)
            {
                MessageBox.Show("Selecione o Tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (valorBaseMes == 0)
            {
                MessageBox.Show("Introduza o Valor por Mês", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comissao == 0)
            {
                MessageBox.Show("Introduza a Comissão", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            resultado = checkTypeCasa();
            
            if(resultado == 1)
            {
                CasaArrendavel casaArrendavel = (CasaArrendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                FormArrendamentos verArrendamentos = new FormArrendamentos(container, casaArrendavel);
                verArrendamentos.Show();
            }
            if(resultado == 0)
            {
                return;
            }
            if(resultado == -1)
            {
                CasaArrendavel casaArrendavel = new CasaArrendavel();

                casaArrendavel.Localidade = localidade;
                casaArrendavel.Rua = rua;
                casaArrendavel.Numero = numero;
                casaArrendavel.Andar = andar;
                casaArrendavel.Area = area;
                casaArrendavel.NumeroAssoalhada = assoalhadas;
                casaArrendavel.NumeroWC = wc;
                casaArrendavel.Tipo = tipo;
                casaArrendavel.NumeroPisos = pisos;
                casaArrendavel.Proprietario = (Cliente)cb_Proprietario.SelectedItem;

                casaArrendavel.ValorBaseMes = valorBaseMes;
                casaArrendavel.Comissao = comissao;

                container.Casas.Add(casaArrendavel);
                container.SaveChanges();

                LerCasas();

                FormArrendamentos formArrendamentos = new FormArrendamentos(container, casaArrendavel);
                formArrendamentos.Show();
            }
        }

        //Check box CAsa Vendavel
        private void checkVendavel_CheckedChanged(object sender, EventArgs e)
        {
            if (checkVendavel.Checked == true)
            {
                gb_Arrendavel.Enabled = false;
                gb_Venda.Enabled = true;
                checkArrendavel.Checked = false;
            }

            if (checkVendavel.Checked == false)
            {
                gb_Venda.Enabled = false;
            }
        }

        //Criar Casa Vendavel
        private void btn_Ver_Venda_Click(object sender, EventArgs e)
        {
            decimal valorNegociavel, comissaoBase;
            string localidade = tb_Localidade.Text;
            string rua = tb_Rua.Text;
            string numero = tb_Numero.Text;
            string andar = tb_Andar.Text;

            int area = Convert.ToInt32(Math.Round(numUp_Area.Value, 0));
            int assoalhadas = Convert.ToInt32(Math.Round(numUp_Assoalhadas.Value, 0));
            int wc = Convert.ToInt32(Math.Round(numUp_WC.Value, 0));
            int pisos = Convert.ToInt32(Math.Round(numUp_Pisos.Value, 0));

            string tipo = cb_Tipo.Text;

            int resultado = 2;

            //convercoes
            decimal.TryParse(tb_ValorNegociavel_Venda.Text, out valorNegociavel);
            decimal.TryParse(tb_ComissaoBase_Venda.Text, out comissaoBase);

            if (localidade.Length == 0)
            {
                MessageBox.Show("Preencha a Localidade", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (rua.Length == 0)
            {
                MessageBox.Show("Preencha a Rua", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (numero.Length == 0)
            {
                MessageBox.Show("Preencha o Numero", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (andar.Length == 0)
            {
                MessageBox.Show("Preencha o Andar", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (area == 0)
            {
                MessageBox.Show("Preencha a Area", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (assoalhadas == 0)
            {
                MessageBox.Show("Preencha a Assoalhada", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (wc == 0)
            {
                MessageBox.Show("Preencha a WC", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (pisos == 0)
            {
                MessageBox.Show("Preencha os Pisos", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (tipo.Length == 0)
            {
                MessageBox.Show("Selecione o Tipo", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (valorNegociavel == 0)
            {
                MessageBox.Show("Introduza o Valor Negociavel", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (comissaoBase == 0)
            {
                MessageBox.Show("Introduza a Comissão Base", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            resultado = checkTypeCasa();

            if(resultado == 1)
            {
                return;
            }
            if(resultado == 0)
            {
                CasaVendavel casaArrendavel = (CasaVendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                FormVenda verVenda = new FormVenda(casaArrendavel, container, 1);
                verVenda.Show();
            }
            if(resultado == -1)
            {
                CasaVendavel casaVendavel = new CasaVendavel();

                casaVendavel.Localidade = localidade;
                casaVendavel.Rua = rua;
                casaVendavel.Numero = numero;
                casaVendavel.Andar = andar;
                casaVendavel.Area = area;
                casaVendavel.NumeroAssoalhada = assoalhadas;
                casaVendavel.NumeroWC = wc;
                casaVendavel.Tipo = tipo;
                casaVendavel.NumeroPisos = pisos;
                casaVendavel.Proprietario = (Cliente)cb_Proprietario.SelectedItem;

                casaVendavel.ValorBaseVenda = valorNegociavel;
                casaVendavel.ValorComissao = comissaoBase;

                container.Casas.Add(casaVendavel);
                container.SaveChanges();

                LerCasas();

                FormVenda formVenda = new FormVenda(casaVendavel, container, 0);
                formVenda.Show();
            }

        }

        private int checkTypeCasa()
        {

            int volta = -1;
            CasaArrendavel casaArrendavel;
            CasaVendavel casaVendavel;
            
            try
            {
                Casa casa = (Casa)casaDataGridView.SelectedRows[0].DataBoundItem;
                try
                {
                    casaArrendavel = (CasaArrendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                    if (casa.IdCasa == casaArrendavel.IdCasa)
                    {
                        volta = 1;
                        return volta;
                    }
                }
                catch (Exception exx)
                {
                    //MessageBox.Show("Erro: CasaArrendavel " + exx.Message);
                }
                try
                {
                    casaVendavel = (CasaVendavel)casaDataGridView.SelectedRows[0].DataBoundItem;
                    if (casa.IdCasa == casaVendavel.IdCasa)
                    {
                        volta = 0;
                        return volta;
                    }
                }
                catch (Exception exxx)
                {
                    //MessageBox.Show("Erro CasaVendavel: " + exxx.Message);
                }

            }
            catch (Exception ex)
            {
                //MessageBox.Show(ex.Message);
            }


            return volta;
        }


        //nao tocar
        //ao fechar abre uma janela GerirClientes
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);

            GerirClientes gs = new GerirClientes(container);
            gs.Show();
        }
    }
}