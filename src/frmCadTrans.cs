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
    public partial class frmCadTrans : Form
    {
        #region Form
        private int tab;

        public frmCadTrans()
        {
            InitializeComponent();
        }
                
        private void frmCadTrans_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_transportadora' table. You can move, or remove it, as needed.
            this.tbl_transportadoraTableAdapter.Fill(this.pORTARIADataSet.tbl_transportadora);
            tab = 0;
            tabControl.SelectedIndex = tab;

        }

        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl.SelectedIndex = tab;
        }

        int id = 0;
        #endregion

        #region Métodos
        private void limpaTela()
        {
            nometxt.Text = "";
            endtxt.Text = "";
            cidadetxt.Text = "";
        }

        private void listaTrans()
        {
            this.tbl_transportadoraTableAdapter.Fill(pORTARIADataSet.tbl_transportadora);
        }

        private void excluir()
        {
            try
            {
                DialogResult result = MessageBox.Show("Deseja excluir a transportadora [ " + GridTrans[1, GridTrans.CurrentRow.Index].Value.ToString() + " ]? ", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    tbl_transportadoraTableAdapter.excluiTrans(int.Parse(GridTrans[0, GridTrans.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show("A transportadora foi excluida com sucesso", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listaTrans();
                    tab = 0;
                    tabControl.SelectedIndex = tab;
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salvar()
        {
            try
            {
                //pORTARIADataSet.tbl_transportadora.Clear();
                //tbl_transportadoraTableAdapter.buscaTrans(pORTARIADataSet.tbl_transportadora, int.Parse(GridTrans[0, GridTrans.CurrentRow.Index].Value.ToString()));

                if (id != 0)
                {
                    tbl_transportadoraTableAdapter.atualizaTrans(nometxt.Text.Trim(), cidadetxt.Text.Trim(), endtxt.Text.Trim(), int.Parse(GridTrans[0, GridTrans.CurrentRow.Index].Value.ToString()));
                    MessageBox.Show("A transportadora foi atualizada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    tbl_transportadoraTableAdapter.inserirTrans(nometxt.Text.Trim(), endtxt.Text.Trim(), cidadetxt.Text.Trim());
                    MessageBox.Show("A transportadora foi inserida com sucesso.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                listaTrans();
                id = 0;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tab = 0;
                listaTrans();
                tabControl.SelectedIndex = tab;
            }
        }

        private void editar()
        {
            if (GridTrans.SelectedRows.Count > 0)
            {
                tab = 1;
                tabControl.SelectedIndex = tab;
                nometxt.Text = GridTrans[1, GridTrans.CurrentRow.Index].Value.ToString().Trim();
                endtxt.Text = GridTrans[2, GridTrans.CurrentRow.Index].Value.ToString().Trim();
                cidadetxt.Text = GridTrans[3, GridTrans.CurrentRow.Index].Value.ToString().Trim();
                id = int.Parse(GridTrans[0, GridTrans.CurrentRow.Index].Value.ToString().Trim());
            }
            else
            {
                MessageBox.Show("Nenhum registro foi selecionado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private bool validaControles()
        {
            if (nometxt.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Nome] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                nometxt.Focus();
                return false;
            }
            if (endtxt.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Endereço]não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                endtxt.Focus();
                return false;
            }
            if (cidadetxt.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Cidade]não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                cidadetxt.Focus();
                return false; 
            }

            return true;
        }

        #endregion

        #region Botões

        private void btnInserir_Click(object sender, EventArgs e)
        {
            tab = 1;
            tabControl.SelectedIndex = tab;
            limpaTela();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        //private void btnExcluir_Click(object sender, EventArgs e)
        //{
         //   excluir();
        //    listaTrans();
        //}

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(validaControles())
            salvar();
         }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tab = 0;
            tabControl.SelectedIndex = tab;
        }
        #endregion
    }
}
