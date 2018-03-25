using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Carga.PORTARIADataSetTableAdapters;
using Carga.ConsultaDataSetTableAdapters;

namespace Carga
{
    public partial class frmEntmerc : Form
        #region form
    {
        public frmEntmerc()
        {
            InitializeComponent();
        }

        private void ent_merc_Load(object sender, EventArgs e)
        {
            
            // TODO: This line of code loads data into the 'consultaDataSet.tbl_entrada_Mercadoria' table. You can move, or remove it, as needed.
            this.tbl_entrada_MercadoriaTableAdapter1.Fill(this.consultaDataSet.tbl_entrada_Mercadoria);
            // TODO: This line of code loads data into the 'consultaDataSet.tbl_locais' table. You can move, or remove it, as needed.
            this.tbl_locaisTableAdapter1.Fill(this.consultaDataSet.tbl_locais);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_gridEntrMerc' table. You can move, or remove it, as needed.
            this.tbl_gridEntrMercTableAdapter.Fill(this.pORTARIADataSet.tbl_gridEntrMerc);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_locais' table. You can move, or remove it, as needed.
            this.tbl_locaisTableAdapter.Fill(this.pORTARIADataSet.tbl_locais);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_transportadora' table. You can move, or remove it, as needed.
            this.tbl_transportadoraTableAdapter.Fill(this.pORTARIADataSet.tbl_transportadora);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_entrada_Mercadoria' table. You can move, or remove it, as needed.
            this.tbl_entrada_MercadoriaTableAdapter.Fill(this.pORTARIADataSet.tbl_entrada_Mercadoria);
            limparTela();
        }

        int linha = 0;

    #endregion

        #region Botões

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaControles())
            {
                salvar();
                limparTela();
            }
            else
            {
                MessageBox.Show("O registro não foi salvo", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GridEntradas.Enabled = true;
            limparTela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limparTela();
            editar();
            
        }

        #endregion

        #region Métodos

        private bool validaControles()
        {
            if (nftxt.Text.Trim() == "" && obstxt.Text.Trim() == "")
            {
                MessageBox.Show("Caso não exista número de Nota Fiscal, o campo [Observação] deve ser preenchido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                obstxt.Focus();
                return false;
            }
            if (dateTimePicker1.Text == "")
            {
                MessageBox.Show("O Campo [Data] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (dateTimePicker2.Text == "")
            {
                MessageBox.Show("O Campo [Hora] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            if (localcombo.Text == "")
            {
                MessageBox.Show("O Campo [Local] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                localcombo.Focus();
                return false;
            }
            if (transcombo.Text == "")
            {
                MessageBox.Show("O Campo [Transportadora] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                transcombo.Focus();
                return false;
            }
            if (motoristatxt.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Motorista] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                motoristatxt.Focus();
                return false;
            }
            if (placamsktxt.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Placa] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                placamsktxt.Focus();
                return false;
            }
            if (responsaveltxt.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Responsavel] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                responsaveltxt.Focus();
                return false;
            }
            return true;
        }

        private void salvar()
        {

            DateTime stDataHora = new DateTime();
            stDataHora = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyyMMdd") + dateTimePicker2.Value.ToString("HHmmss"), "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);

            //tbl_entrada_MercadoriaTableAdapter.buscaRegistro(pORTARIADataSet.tbl_entrada_Mercadoria, int.Parse(GridEntradas[0, GridEntradas.CurrentRow.Index].Value.ToString()));

            try
            {
                if (linha != 0)
                {
                    tbl_entrada_MercadoriaTableAdapter.atualizaRegistro(stDataHora, int.Parse(localcombo.SelectedValue.ToString()), nftxt.Text.Trim(), serietxt.Text.Trim(), int.Parse(transcombo.SelectedValue.ToString()), motoristatxt.Text.Trim(), placamsktxt.Text.Trim(), responsaveltxt.Text.Trim(),obstxt.Text.Trim() , int.Parse(GridEntradas[0, GridEntradas.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(" O registro foi atualizado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridEntradas.Enabled = true;
                }
                else
                {
                    tbl_entrada_MercadoriaTableAdapter.inserirRegistros(stDataHora, int.Parse(localcombo.SelectedValue.ToString()), nftxt.Text.Trim(), serietxt.Text.Trim(), int.Parse(transcombo.SelectedValue.ToString()), motoristatxt.Text.Trim(), placamsktxt.Text.Trim(), responsaveltxt.Text.Trim(), obstxt.Text.Trim());
                    MessageBox.Show(" O registro foi inserido com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            listaGrid();
            linha = 0;
        }

        private void limparTela()
        {
            nftxt.Text = "";
            serietxt.Text = "";
            localcombo.SelectedIndex = -1;
            transcombo.SelectedIndex = -1;
            motoristatxt.Text = "";
            placamsktxt.Text = "";
            responsaveltxt.Text = "";
            obstxt.Text = "";

        }

        private void listaGrid()
        {
            tbl_gridEntrMercTableAdapter.Fill(pORTARIADataSet.tbl_gridEntrMerc);
        }

        private void editar()
        {
            if (GridEntradas.SelectedRows.Count > 0)
            {
                //DateTime dtEntrada = new DateTime();
                DialogResult result = MessageBox.Show("Deseja editar o registro selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GridEntradas.Enabled = false;

                    //dtEntrada = DateTime.ParseExact(GridEntradas[1, GridEntradas.CurrentRow.Index].Value.ToString().Trim(), "d/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    tbl_entrada_MercadoriaTableAdapter.buscaRegistro(pORTARIADataSet.tbl_entrada_Mercadoria, int.Parse(GridEntradas[0, GridEntradas.CurrentRow.Index].Value.ToString().Trim()));

                    nftxt.Text = pORTARIADataSet.tbl_entrada_Mercadoria[0].nf;
                    serietxt.Text = pORTARIADataSet.tbl_entrada_Mercadoria[0].serie;
                    localcombo.SelectedValue = pORTARIADataSet.tbl_entrada_Mercadoria[0].locais_origem;
                    transcombo.SelectedValue = pORTARIADataSet.tbl_entrada_Mercadoria[0].id_transportadora;
                    dateTimePicker1.Value = pORTARIADataSet.tbl_entrada_Mercadoria[0].data_entrada;
                    dateTimePicker2.Value = pORTARIADataSet.tbl_entrada_Mercadoria[0].data_entrada;
                    motoristatxt.Text = pORTARIADataSet.tbl_entrada_Mercadoria[0].motorista;
                    placamsktxt.Text = pORTARIADataSet.tbl_entrada_Mercadoria[0].placa_veiculo;
                    responsaveltxt.Text = pORTARIADataSet.tbl_entrada_Mercadoria[0].responsavel_entrada;
                    obstxt.Text = pORTARIADataSet.tbl_entrada_Mercadoria[0].obs;


                    //nftxt.Text = GridEntradas[3, GridEntradas.CurrentRow.Index].Value.ToString().Trim();
                    //serietxt.Text = GridEntradas[4, GridEntradas.CurrentRow.Index].Value.ToString().Trim();
                    //localcombo.Text = GridEntradas[2, GridEntradas.CurrentRow.Index].Value.ToString();
                    //transcombo.Text = GridEntradas[5, GridEntradas.CurrentRow.Index].Value.ToString();
                    //dateTimePicker1.Value = dtEntrada;
                    //motoristatxt.Text = GridEntradas[6, GridEntradas.CurrentRow.Index].Value.ToString().Trim();
                    //placamsktxt.Text = GridEntradas[7, GridEntradas.CurrentRow.Index].Value.ToString().Trim();
                    //responsaveltxt.Text = GridEntradas[8, GridEntradas.CurrentRow.Index].Value.ToString().Trim();
                    //dateTimePicker2.Value = dtEntrada;

                    linha = int.Parse(GridEntradas[0, GridEntradas.CurrentRow.Index].Value.ToString());


                    //tbl_entrada_MercadoriaTableAdapter.buscaRegistro(pORTARIADataSet.tbl_entrada_Mercadoria, (int)GridEntradas[8, GridEntradas.CurrentRow.Index].Value);
                }
                else
                {
                    limparTela();
                }
            }
            else
            {
                MessageBox.Show("O registro não foi selecionado!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        #endregion

        private void nftxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void serietxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        private void filtraLocalOrigemToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_locaisTableAdapter1.FiltraLocalOrigem(this.consultaDataSet.tbl_locais);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
               
              

        }
 
    
    
     
    
  
       
    }

