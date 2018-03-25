using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Carga.PORTARIADataSetTableAdapters;

namespace Carga
{
    public partial class frmCadUser : Form
    {
        private int tab;

        #region Form
        public frmCadUser()
        {
            InitializeComponent();
        }

        private void frmCadUser_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_userProg' table. You can move, or remove it, as needed.
            this.tbl_userProg.Fill(this.pORTARIADataSet.tbl_userProg);

            tbl_userProg tbl_UsrProg = new tbl_userProg();

            tab = 0;
            tabControl1.SelectedIndex = tab;

            listaUsuarios();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            tabControl1.SelectedIndex = tab; 
        }

        private void GridUser_DoubleClick(object sender, EventArgs e)
        {
            editar();
        }

        #endregion

        #region Botões

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            tab = 0;
            tabControl1.SelectedIndex = tab;
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            excluiUsuario();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            tab = 1;
            tabControl1.SelectedIndex = tab;
            txtUsuario.Text = "";
            limpaTela();
            txtUsuario.Enabled = true;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if (validaControles())
                salvar();

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            editar();
        }

        #endregion

        #region métodos

        private void limpaTela()
        {
            txtUsuario.Text = "";
            nomeTextBox.Text = "";
            situacaoCheckBox.Checked = true;

        }

        private void excluiUsuario()
        {
            try
            {
                //DialogResult result = MessageBox.Show("Deseja excluir o usuário?"); ANTES
                //Concatenando o nome do usuario no grid com a mensagem.

                DialogResult result = MessageBox.Show("Deseja excluir o usuário [ " + GridUser[0, GridUser.CurrentRow.Index].Value.ToString().Trim() + " ]?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                //Buscando pelo usuario do grid o valor a ser apagado. o 0 faz referencia a coluna do grid.
                if (result == DialogResult.Yes)
                {
                    //  tbl_userTableAdapter.excluiUsuario(GridUser[0, GridUser.CurrentRow.Index].Value.ToString().Trim()) ;

                    tbl_userTableAdapter.excluiUsuario(GridUser[1, GridUser.CurrentRow.Index].Value.ToString().Trim());
                    tbl_userProg tbl_UsrProg = new tbl_userProg();
                    tbl_UsrProg.excluiProgramas(GridUser[2, GridUser.CurrentRow.Index].Value.ToString().Trim());


                    listaUsuarios();

                    tab = 0;
                    tabControl1.SelectedIndex = tab;

                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void listaUsuarios()
        {
            this.tbl_userTableAdapter.Fill(this.pORTARIADataSet.tbl_user);
        }

        private bool validaControles()
        {
            if (nomeTextBox.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Nome] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                nomeTextBox.Focus();
                return false;
            }
            if (txtUsuario.Text.Trim() == "")
            {
                MessageBox.Show("O Campo [Usuário]não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtUsuario.Focus();
                return false;
            }

            return true;
        }

        private void buscaUsuario()
        {
            try
            {
                tbl_userTableAdapter tbu = new tbl_userTableAdapter();
                tbu.buscaUsuario(pORTARIADataSet.tbl_user, txtUsuario.Text);
            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }                

        private void salvar()
        {
            string cripSenha;
            SymmCrypto crip = new SymmCrypto(SymmCrypto.SymmProvEnum.DES);
            cripSenha = crip.Encrypting("autoneum", "6666");

            try
            {
                pORTARIADataSet.tbl_user.Clear();
                tbl_userTableAdapter.buscaUsuario(pORTARIADataSet.tbl_user, txtUsuario.Text.Trim()); //busca usuario na tabela.

                if (pORTARIADataSet.tbl_user.Rows.Count > 0) 
                {

                    tbl_userTableAdapter.atualizaUsuario(txtUsuario.Text.Trim(), nomeTextBox.Text.Trim(), situacaoCheckBox.Checked);

                    if (alterarsenhacheck.Checked)
                    {
                        tbl_userTableAdapter.atualizaSenha(cripSenha, txtUsuario.Text.Trim());
                        MessageBox.Show("A senha foi alterada com sucesso", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else //novo usuario
                {
                    tbl_userTableAdapter.insereUsuario(nomeTextBox.Text.Trim(), txtUsuario.Text.Trim(), cripSenha, situacaoCheckBox.Checked);
                    MessageBox.Show("Senha: autoneum", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

                tbl_userProg tbl = new tbl_userProg();
                tbl.excluiProgramas(txtUsuario.Text.Trim());
                salvaAcessos(tevProg.Nodes, txtUsuario.Text.Trim());

                listaUsuarios();

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                tab = 0;
                tabControl1.SelectedIndex = tab;

            }

        }

        private void editar()
        {

            if (GridUser.RowCount > 0)
            {
                tab = 1;
                tabControl1.SelectedIndex = tab;
                txtUsuario.Text = GridUser[1, GridUser.CurrentRow.Index].Value.ToString().Trim();
                nomeTextBox.Text = GridUser[0, GridUser.CurrentRow.Index].Value.ToString().Trim();
                situacaoCheckBox.Checked = (bool)GridUser[2, GridUser.CurrentRow.Index].Value;

                limpaTreeView(tevProg.Nodes);


                tbl_userProg tbl = new tbl_userProg();

                tbl.selecionaAcessos(pORTARIADataSet.tbl_userProg, txtUsuario.Text.Trim());
                              
                if (pORTARIADataSet.tbl_userProg.Rows.Count > 0)
                {
                    
                    for (int a = 0; a < pORTARIADataSet.tbl_userProg.Rows.Count; a++)
                    {
                        checaAcessos(tevProg.Nodes, pORTARIADataSet.tbl_userProg[a].idprog);
                    }
                }
            }
        }

        private void limpaTreeView(TreeNodeCollection treenode)
        {
            foreach (TreeNode node in treenode)
            {
                if (node.Nodes.Count > 0)
                {
                    limpaTreeView(node.Nodes);
                }

                  node.Checked = false;

            }
        }
       

        private void salvaAcessos(TreeNodeCollection treenode, string cod_usua)
        {

            tbl_userProg tbl = new tbl_userProg();
            try
            {
                foreach (TreeNode node in treenode)
                {
                    if (node.Nodes.Count > 0)
                    {
                        salvaAcessos(node.Nodes, cod_usua);
                    }
                    if (node.Checked)
                    {
                        tbl.insereAcessos(cod_usua, node.Name);
                    }
                }
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checaAcessos(TreeNodeCollection treenode, string cod_prog)
        {
            foreach (TreeNode node in treenode)
            {

                if (node.Name == cod_prog.Trim())
                {
                    node.Checked = true;
                }
                else  //Se o node não estiver flagado ele nao retornara um valor maior que zero.
                {
                    if (node.Nodes.Count > 0)
                    {
                        checaAcessos(node.Nodes, cod_prog);
                    }
                }
            }
        }

        #endregion


    }
}
