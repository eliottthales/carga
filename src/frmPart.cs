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
    public partial class frmPart : Form
    {
        public frmPart()
        {
            InitializeComponent();
        }

        

        private void frmPart_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultaDataSet.tbl_part' table. You can move, or remove it, as needed.
            this.tbl_partTableAdapter.Fill(this.consultaDataSet.tbl_part);
            // TODO: This line of code loads data into the 'consultaDataSet.tbl_cad_Func' table. You can move, or remove it, as needed.
            this.tbl_cad_FuncTableAdapter.Fill(this.consultaDataSet.tbl_cad_Func);
            
                        

        }

        private void salvar()
        {
            
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void placamsktxt_Leave(object sender, EventArgs e)
        {
            if (placamsktxt.Text != "")
            {
                ConsultaDataSet ds = new ConsultaDataSet();
                ConsultaDataSetTableAdapters.tbl_cad_FuncTableAdapter tbcad = new Carga.ConsultaDataSetTableAdapters.tbl_cad_FuncTableAdapter();
                tbcad.buscaPlaca(ds.tbl_cad_Func, placamsktxt.Text.Trim());
                if (ds.tbl_cad_Func.Count > 0)
                {
                    nometxt.Text = ds.tbl_cad_Func[0].nome;
                    cnhtxt.Text = Convert.ToString(ds.tbl_cad_Func[0].CNH);
                    modelotxt.Text = ds.tbl_cad_Func[0].modelo;

                }
                else
                {
                    MessageBox.Show("A Placa inserida não existe", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
        
    }
}
