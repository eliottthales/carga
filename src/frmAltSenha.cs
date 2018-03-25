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
    public partial class frmAltSenha : Form
    {
        public frmAltSenha()
        {
            InitializeComponent();
        }

        private void frmAltSenha_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_user' table. You can move, or remove it, as needed.
            this.tbl_userTableAdapter.Fill(this.pORTARIADataSet.tbl_user);
            txtSenha.PasswordChar = '\u25CF';
            txtNovaSenha.PasswordChar = '\u25CF';
            txtConfirmar.PasswordChar = '\u25CF';
            lblViewUsr.Text = Program.strUsuarioAtu;
        }

        private bool validaControle()
        {
            string cripSenha = "";

            if (txtSenha.Text.Trim() == "")
            {
                MessageBox.Show("O campo senha [Senha Atual] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSenha.Focus();
                return false;
            }
            if (txtNovaSenha.Text.Trim() == "")
            {
                MessageBox.Show("O campo nova senha não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNovaSenha.Focus();
                return false;
            }
            if (txtConfirmar.Text.Trim() == "")
            {
                MessageBox.Show("O campo Confirmar não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtConfirmar.Focus();
                return false;
            }
            if (txtNovaSenha.Text != txtConfirmar.Text)
            {
                MessageBox.Show("O campo Confirmar não pode ser diferente do campo Nova Senha.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtConfirmar.Focus();
                return false;
            }
            
 
            try
            {
                
                SymmCrypto crip = new SymmCrypto(SymmCrypto.SymmProvEnum.DES);
                cripSenha = crip.Encrypting(txtSenha.Text.Trim(), "6666");
                
                tbl_userTableAdapter.buscaUsuario(pORTARIADataSet.tbl_user, lblViewUsr.Text); //dados do usuario

                if (pORTARIADataSet.tbl_user.Rows.Count > 0)  // retornou alguma linha
                {
                    if (pORTARIADataSet.tbl_user[0].senha.Trim() != cripSenha)   //a senha bate
                        MessageBox.Show("Senha Inválida.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Usuário não localizado.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            catch (System.Data.SqlClient.SqlException err)
            {
                MessageBox.Show(err.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            
    
            return true;

        }
        private void btnAlterar_Click(object sender, EventArgs e)
        {
            if (validaControle())
            {
                try
                {
                    string cripSenha = "";
                    SymmCrypto crip = new SymmCrypto(SymmCrypto.SymmProvEnum.DES);
                    cripSenha = crip.Encrypting(txtNovaSenha.Text.Trim(), "6666");
                    tbl_userTableAdapter.atualizaSenha(cripSenha, lblViewUsr.Text);
                    MessageBox.Show("Senha alterada com sucesso!", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                catch (Exception err)
                {
                    MessageBox.Show(err.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }

}
