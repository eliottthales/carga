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
    public partial class frmResiduo : Form
    {
        public frmResiduo()
        {
            InitializeComponent();
        }

        int linha = 0;

        private void frmResiduo_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_locais' table. You can move, or remove it, as needed.
            this.tbl_locaisTableAdapter.Fill(this.pORTARIADataSet.tbl_locais);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_transportadora' table. You can move, or remove it, as needed.
            this.tbl_transportadoraTableAdapter.Fill(this.pORTARIADataSet.tbl_transportadora);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_residuo' table. You can move, or remove it, as needed.
            this.tbl_residuoTableAdapter.Fill(this.pORTARIADataSet.tbl_residuo);
            limparTela();
        }

        #region métodos

        private void editar()
        {
            if (GridResiduos.SelectedRows.Count > 0)
            {

                //DateTime dtEntrada = new DateTime();
                //dtEntrada = DateTime.ParseExact(datePicker.Value.ToString("yyyyMMdd") + timePicker.Value.ToString("HHmmss"), "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);

                //DateTime stDataHora = new DateTime();
                //stDataHora = DateTime.ParseExact(dateTimePicker1.Value.ToString("yyyyMMdd") + dateTimePicker2.Value.ToString("HHmmss"), "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);
                
                //DateTime dtEntrada = new DateTime();
                //dtEntrada = DateTime.ParseExact(GridResiduos[1, GridResiduos.CurrentRow.Index].Value.ToString().Trim(), "d/MM/yyyy HH:mm:ss", System.Globalization.CultureInfo.InvariantCulture);
                DialogResult result = MessageBox.Show("Deseja editar o registro selecionado?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    GridResiduos.Enabled = false;
                    
                    tbl_residuoTableAdapter.BuscaRegistro(pORTARIADataSet.tbl_residuo, int.Parse(GridResiduos[0, GridResiduos.CurrentRow.Index].Value.ToString().Trim()));
                    //tbl_locaisTableAdapter.Adapter = pORTARIADataSet.DataSetName
                    nftxt.Text = pORTARIADataSet.tbl_residuo[0].nf;
                    serietxt.Text = pORTARIADataSet.tbl_residuo[0].serie;
                    datePicker.Value = pORTARIADataSet.tbl_residuo[0].data;
                    timePicker.Value = pORTARIADataSet.tbl_residuo[0].data;
                    placamasktxt.Text = pORTARIADataSet.tbl_residuo[0].placa_veiculo;
                    mottxt.Text = pORTARIADataSet.tbl_residuo[0].motorista;
                    transcombo.SelectedValue = pORTARIADataSet.tbl_residuo[0].id_transportadora;
                    localcombo.SelectedValue = pORTARIADataSet.tbl_residuo[0].locais_destino;

                    linha = int.Parse(GridResiduos[0, GridResiduos.CurrentRow.Index].Value.ToString());
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

        private void salvar()
        {
            DateTime stDataHora = new DateTime();
            stDataHora = DateTime.ParseExact(datePicker.Value.ToString("yyyyMMdd") + timePicker.Value.ToString("HHmmss"), "yyyyMMddHHmmss", System.Globalization.CultureInfo.InvariantCulture);

            try
            {
                if (linha != 0)
                {
                    tbl_residuoTableAdapter.atualizaRegistro(stDataHora, placamasktxt.Text.Trim(), mottxt.Text.Trim(), nftxt.Text.Trim(), serietxt.Text.Trim(), int.Parse(transcombo.SelectedValue.ToString()), int.Parse(localcombo.SelectedValue.ToString()), int.Parse(GridResiduos[0, GridResiduos.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show(" O registro foi atualizado com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GridResiduos.Enabled = true;
                }
                else
                {
                    tbl_residuoTableAdapter.inserirRegistros(stDataHora, placamasktxt.Text.Trim(), mottxt.Text.Trim(), nftxt.Text.Trim(), serietxt.Text.Trim(), int.Parse(transcombo.SelectedValue.ToString()), int.Parse(localcombo.SelectedValue.ToString()));
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

        private bool validaControles()
        {
            if(localcombo.Text == "")
            {
            MessageBox.Show("O Campo [Destino] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            nftxt.Focus();
            return false;
            }
            if (transcombo.Text == "")
            {
                MessageBox.Show("O Campo [Transportadora] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                nftxt.Focus();
                return false;
            }
            if (mottxt.Text == "")
            {
                MessageBox.Show("O Campo [Motorista] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                nftxt.Focus();
                return false;
            }
            if (placamasktxt.Text == "")
            {
                MessageBox.Show("O Campo [Placa] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                nftxt.Focus();
                return false;
            }
            return true;
        }

        private void listaGrid()
        {
            this.tbl_residuoTableAdapter.Fill(this.pORTARIADataSet.tbl_residuo);
        }

        private void limparTela()
        {
            nftxt.Text = "";
            serietxt.Text = "";
            placamasktxt.Text = "";
            mottxt.Text = "";
            transcombo.SelectedValue = -1;
            localcombo.SelectedValue = -1;

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
                limparTela();
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            limparTela();
            editar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            GridResiduos.Enabled = true;
            limparTela();
            listaGrid();
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

              

        
    }
}
