using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Carga
{
    public partial class frmSaidamerc : Form
    {
        #region form

        public frmSaidamerc()
        {
            InitializeComponent();
        }

        
        private void frmSaidamerc_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_transportadora' table. You can move, or remove it, as needed.
            this.tbl_transportadoraTableAdapter.Fill(this.pORTARIADataSet.tbl_transportadora);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_locais' table. You can move, or remove it, as needed.
            this.tbl_locaisTableAdapter.Fill(this.pORTARIADataSet.tbl_locais);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_locais' table. You can move, or remove it, as needed.
            this.tbl_saida_MercadoriaTableAdapter.Fill(this.pORTARIADataSet.tbl_saida_Mercadoria);
            limparTela();
                
        }

        int linha = 0;

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
            
            return true;
        }

        private void salvar()
        {
            DateTime stDataHora = new DateTime();
            stDataHora = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyyMMdd") + dateTimePicker2.Value.ToString("HHmmss"), "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                if (linha != 0)
                {
                    tbl_saida_MercadoriaTableAdapter.atualizaRegistro(stDataHora, int.Parse(localcombo.SelectedValue.ToString()), nftxt.Text.Trim(), serietxt.Text.Trim(), int.Parse(transcombo.SelectedValue.ToString()), motoristatxt.Text.Trim(), placamsktxt.Text.Trim(), obstxt.Text.Trim(), int.Parse(GridSaidas[0, GridSaidas.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(" O registro foi atualizado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridSaidas.Enabled = true;
                }
                else
                {
                    tbl_saida_MercadoriaTableAdapter.insereRegistro(stDataHora, int.Parse(localcombo.SelectedValue.ToString()), nftxt.Text.Trim(), serietxt.Text.Trim(), int.Parse(transcombo.SelectedValue.ToString()), motoristatxt.Text.Trim(), placamsktxt.Text.Trim(), obstxt.Text.Trim());
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

        private void listaGrid()
        {
            tbl_saida_MercadoriaTableAdapter.Fill(pORTARIADataSet.tbl_saida_Mercadoria);
        }

        private void limparTela()
        {
            nftxt.Text = "";
            serietxt.Text = "";
            localcombo.SelectedIndex = -1;
            transcombo.SelectedIndex = -1;
            motoristatxt.Text = "";
            placamsktxt.Text = "";
            obstxt.Text = "";

        }

        private void editar()
        {
            if (GridSaidas.SelectedRows.Count > 0)
            {
                //DateTime dtSaida = new DateTime();
                DialogResult result = MessageBox.Show("Deseja editar o registro selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GridSaidas.Enabled = false;

                    //dtSaida = DateTime.ParseExact(GridSaidas[1, GridSaidas.CurrentRow.Index].Value.ToString().Trim(), "d/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                    tbl_saida_MercadoriaTableAdapter.buscaRegistro(pORTARIADataSet.tbl_saida_Mercadoria, int.Parse(GridSaidas[0, GridSaidas.CurrentRow.Index].Value.ToString().Trim()));

                    nftxt.Text = pORTARIADataSet.tbl_saida_Mercadoria[0].nf;
                    serietxt.Text = pORTARIADataSet.tbl_saida_Mercadoria[0].serie;
                    localcombo.SelectedValue = pORTARIADataSet.tbl_saida_Mercadoria[0].locais_destino;
                    transcombo.SelectedValue = pORTARIADataSet.tbl_saida_Mercadoria[0].id_transportadora;
                    dateTimePicker1.Value = pORTARIADataSet.tbl_saida_Mercadoria[0].data_saida;
                    dateTimePicker2.Value = pORTARIADataSet.tbl_saida_Mercadoria[0].data_saida;
                    motoristatxt.Text = pORTARIADataSet.tbl_saida_Mercadoria[0].motorista;
                    placamsktxt.Text = pORTARIADataSet.tbl_saida_Mercadoria[0].placa_veiculo;
                    obstxt.Text = pORTARIADataSet.tbl_saida_Mercadoria[0].obs;

                    //nftxt.Text = GridSaidas[3, GridSaidas.CurrentRow.Index].Value.ToString().Trim();
                    //serietxt.Text = GridSaidas[4, GridSaidas.CurrentRow.Index].Value.ToString().Trim();
                    //localcombo.SelectedValue = GridSaidas[2, GridSaidas.CurrentRow.Index].Value.ToString();
                    //transcombo.SelectedValue = GridSaidas[5, GridSaidas.CurrentRow.Index].Value.ToString();
                    //dateTimePicker1.Value = dtSaida;
                    //motoristatxt.Text = GridSaidas[6, GridSaidas.CurrentRow.Index].Value.ToString().Trim();
                    //placamsktxt.Text = GridSaidas[7, GridSaidas.CurrentRow.Index].Value.ToString().Trim();
                    //obstxt.Text = GridSaidas[8, GridSaidas.CurrentRow.Index].Value.ToString().Trim();
                    //dateTimePicker2.Value = dtSaida;

                    linha = int.Parse(GridSaidas[0, GridSaidas.CurrentRow.Index].Value.ToString());
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

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limparTela();
            editar();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GridSaidas.Enabled = true;
            limparTela();
            this.tbl_saida_MercadoriaTableAdapter.Fill(this.pORTARIADataSet.tbl_saida_Mercadoria);
        }
        
        #endregion

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_saida_MercadoriaTableAdapter.FillBy(this.pORTARIADataSet.tbl_saida_Mercadoria);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

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

        private void selecionaTipo2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tbl_locaisTableAdapter.SelecionaTipo2(this.pORTARIADataSet.tbl_locais);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void localcombo_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                this.tbl_locaisTableAdapter.SelecionaTipo2(this.pORTARIADataSet.tbl_locais);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            
        }
    }
       
}   
