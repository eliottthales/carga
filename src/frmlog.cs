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
    public partial class frmlog : Form
    {
        public frmlog()
        {
            InitializeComponent();
        }
         
        private bool validaControles()
        {
            if (txtLogin.Text.Trim() == "") 
            {
                MessageBox.Show("O campo [ Login ] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtLogin.Focus();
                return false;
            }

            if (txtSenha.Text.Trim() == "") 
            {
                MessageBox.Show("O campo [ Senha ] não pode estar em branco.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtSenha.Focus();
                return false;
            }

            return true;
        }


        private void validaAcesso()
        {

            string cripSenha = "";
            SymmCrypto crip = new SymmCrypto(SymmCrypto.SymmProvEnum.DES);
            cripSenha = crip.Encrypting(txtSenha.Text.Trim(), "6666");

            if (txtLogin.Text.Trim() != "ADMCARGA") 
            {

                try   //Para acesso ao banco.
                {
                    tbl_userTableAdapter.buscaUsuario(pORTARIADataSet.tbl_user, txtLogin.Text);
                    if (pORTARIADataSet.tbl_user.Rows.Count > 0)
                    {  
                        if (pORTARIADataSet.tbl_user[0].senha.Trim() != cripSenha)
                        {
                            MessageBox.Show("Usuário ou senha inválido.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            txtSenha.Text = "";
                            return;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não localizado", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
                catch (System.Data.SqlClient.SqlException err) 
                {
                    MessageBox.Show(err.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                catch (Exception err) 
                {
                    MessageBox.Show(err.Message, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Program.strUsuarioAtu = txtLogin.Text;    
                Program.flgAcesso = true;                 
                this.Close();         
            }
            else
            {
                if (txtSenha.Text.Trim() == "CARGA") 
                {
                    Program.strUsuarioAtu = txtLogin.Text; 
                    Program.flgAcesso = true; 
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuário ou senha inválido.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                    txtLogin.Focus();
                   
                }
            }
        }


        private void frmlog_Load(object sender, EventArgs e)
        {
            this.tbl_userTableAdapter.Fill(this.pORTARIADataSet.tbl_user);
            
            string strLogin = "";
            txtSenha.Focus();
            txtSenha.Select();
            try
            {
                strLogin = System.Security.Principal.WindowsIdentity.GetCurrent().Name;
                strLogin = strLogin.Substring((strLogin.IndexOf("\\") + 1), (strLogin.Length - (strLogin.IndexOf("\\") + 1)));
            }
            catch
            {

            }
            txtLogin.Text = strLogin;
            txtSenha.PasswordChar = '\u25CF';

            
        }


        private void SelectText()
        {
            TextBox textbox = this.ActiveControl as TextBox;
            textbox.Select(0, textbox.Text.Length);
        }

        private void txtSenha_Enter(object sender, EventArgs e)
        {
            SelectText();
        }

        private void txtLogin_Enter(object sender, EventArgs e)
        {
            SelectText();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if (validaControles())
                validaAcesso();
        }
                

        private void frmlog_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar.CompareTo((char)Keys.Enter)) == 0)
            {
                if (validaControles())
                    validaAcesso();
            }
            else if ((e.KeyChar.CompareTo((char)Keys.Return)) == 0)
            {
                e.Handled = true;
                SendKeys.Send("{TAB}");
            }
            else if ((e.KeyChar.CompareTo((char)Keys.Escape)) == 0)
            {
                this.Close();
            }

        }

         
    }
}
