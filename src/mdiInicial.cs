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
    public partial class mdiInicial : Form
    {
        #region Form

        public mdiInicial()
        {
            InitializeComponent();
        }

        private void mdiInicial_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_userProg' table. You can move, or remove it, as needed.
            this.tbl_userProg.Fill(this.pORTARIADataSet.tbl_userProg);

            if (Program.strUsuarioAtu == "ADMCARGA")
            {
                liberaAcessosADM(menuStrip1.Items);
            }
            else
            {
                selecionaAcessos(pORTARIADataSet, Program.strUsuarioAtu);
                for (int a = 0; a < pORTARIADataSet.tbl_userProg.Rows.Count; a++)
                {
                    liberaAcessoUser(menuStrip1.Items, pORTARIADataSet.tbl_userProg[a].idprog); //Esse manda
                }
            }
            if(Program.strUsuarioAtu == "pbetim")
            {
                alterarSenhaToolStripMenuItem.Enabled = false;
            }
            tsslUsuario.Text = "Usuário: " + Program.strUsuarioAtu;
        }
                
        #endregion

        #region Botões

        private void entradaDeMercadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmEntmerc frmEM = new frmEntmerc();
            frmEM.MdiParent = this;
            frmEM.Show();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Deseja finalizar a aplicação?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
                this.Dispose();
        }

        private void saídaDeMercadoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSaidamerc frmSA = new frmSaidamerc();
            frmSA.MdiParent = this;
            frmSA.Show();
        }

        private void fiorinoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmfiorino frmF = new frmfiorino();
            frmF.MdiParent = this;
            frmF.Show();
        }

        private void particularToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPart frmPar = new frmPart();
            frmPar.MdiParent = this;
            frmPar.Show();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmVisit frmV = new frmVisit();
            frmV.MdiParent = this;
            frmV.Show();
        }

        private void usuáriosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadUser frmCU = new frmCadUser();
            frmCU.MdiParent = this;
            frmCU.Show();
        }

        private void saídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmResiduo frmRes = new frmResiduo();
            frmRes.MdiParent = this;
            frmRes.Show();
        }

        private void locaisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadLocs frmCL = new frmCadLocs();
            frmCL.MdiParent = this;
            frmCL.Show();

        }

        private void transportadoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadTrans frmCT = new frmCadTrans();
            frmCT.MdiParent = this;
            frmCT.Show();
        }

        private void entradaDeMercadoriaPorDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelCarga frmRC = new frmRelCarga();
            frmRC.MdiParent = this;
            frmRC.Show();           
        }

        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAltSenha frmAS = new frmAltSenha();
            frmAS.MdiParent = this;

            if (Program.strUsuarioAtu.Trim() == "ADMCARGA")
            {
                MessageBox.Show("Por segurança não é possível alterar a senha ADMINISTRADOR do sistema.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                frmAS.Show();
            }
        }

        private void residuosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRelRes frmRR = new frmRelRes();
            frmRR.MdiParent = this;
            frmRR.Show();
        }

        #endregion

        #region metodos
        public void liberaAcessosADM(ToolStripItemCollection treeitem)
        {
            foreach (ToolStripMenuItem item in treeitem)
            {
                if (item.DropDownItems.Count > 0)
                {
                    liberaAcessosADM(item.DropDownItems);
                }
                item.Enabled = true;
            }
        }
        public void liberaAcessoUser(ToolStripItemCollection treeitem, string idprog)
        {
            foreach (ToolStripMenuItem item in treeitem)
            {
                if (idprog.Trim() == item.Name.Trim())
                {
                    item.Enabled = true;
                }
                else
                {
                    if (item.DropDownItems.Count > 0)
                    {
                        liberaAcessoUser(item.DropDownItems, idprog); //p esse.
                    }
                }
            }
        }
        private void selecionaAcessos(PORTARIADataSet pdataset, string cod_usua)
        {
            try
            {
                pdataset.tbl_userProg.Clear();
                tbl_userProg.selecionaAcessos(pdataset.tbl_userProg, cod_usua.Trim());  

            }
            catch (Exception err)
            {
                throw new Exception(err.Message);
            }
        }
        #endregion
      
    }
}
