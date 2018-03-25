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
    public partial class frmCadLocs : Form
    {
        #region form
        private int tab;
        private int linha;
        public frmCadLocs()
        {
            InitializeComponent();
        }

        private void frmCadLocs_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_residuo' table. You can move, or remove it, as needed.
            this.tbl_residuoTableAdapter.Fill(this.pORTARIADataSet.tbl_residuo);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_locais' table. You can move, or remove it, as needed.
            this.tbl_locaisTableAdapter.Fill(this.pORTARIADataSet.tbl_locais);
            tab = 0;
            tabControl.SelectedIndex = tab;
        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = tab;
        }
        #endregion

        #region Métodos

        private void editar()
        {
            if (GridLocais.SelectedRows.Count > 0)
            {
                tab = 1;
                tabControl.SelectedIndex = tab;
                nometxt.Text = GridLocais[1, GridLocais.CurrentRow.Index].Value.ToString().Trim();
                endtxt.Text = GridLocais[2, GridLocais.CurrentRow.Index].Value.ToString().Trim();
                tipotxt.Text = GridLocais[3, GridLocais.CurrentRow.Index].Value.ToString().Trim();
            }
            else
            {
                MessageBox.Show("Nenhum registro foi selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            linha = int.Parse(GridLocais[0, GridLocais.CurrentRow.Index].Value.ToString().Trim());
        }
                
        private bool validaControles()
        {
            if (nometxt.Text == "")
            {
                MessageBox.Show("O Campo [Localidade] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                nometxt.Focus();
                return false;
            }
            if (endtxt.Text == "")
            {
                MessageBox.Show("O Campo [Endereço] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                endtxt.Focus();
                return false;
            }
            if (tipotxt.Text == "")
            {
                MessageBox.Show("O Campo [Tipo] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                tipotxt.Focus();
                return false;
            }
            return true;
        }

        private void salvar()
        {
            try
            {
                if (linha != 0)
                {
                    tbl_locaisTableAdapter.atualizaLocal(nometxt.Text, endtxt.Text, int.Parse(tipotxt.Text.Trim()), int.Parse(GridLocais[0, GridLocais.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show("O local foi atualizado com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbl_locaisTableAdapter.inserirLocal(nometxt.Text.Trim(), endtxt.Text.Trim(), int.Parse(tipotxt.Text.Trim()));
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tab = 0;
                listaLocais();
                tabControl.SelectedIndex = tab;

            }
        }

        private void limpaTela()
        {
            nometxt.Text = "";
            endtxt.Text = "";
            tipotxt.Text = "";
        }

        private void listaLocais()
        {
            tbl_locaisTableAdapter.Fill(pORTARIADataSet.tbl_locais);
        }
        #endregion

        #region Botões


        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }
        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnInserir_Click(object sender, EventArgs e)
        {
            tab = 1;
            tabControl.SelectedIndex = tab;
            limpaTela();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tab = 0;
            tabControl.SelectedIndex = tab;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaControles())
                {
                    salvar();
                }
        }

        #endregion

        

        
    }
}
