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
    public partial class frmRelCarga : Form
    {
        public frmRelCarga()
        {
            InitializeComponent();
        }

        private void frmRelCarga_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'consultaDataSet.tbl_entrada_Mercadoria' table. You can move, or remove it, as needed.
            this.tbl_entrada_MercadoriaTableAdapter.Fill(this.consultaDataSet.tbl_entrada_Mercadoria);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_locais' table. You can move, or remove it, as needed.
            this.tbl_locaisTableAdapter.Fill(this.pORTARIADataSet.tbl_locais);
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_transportadora' table. You can move, or remove it, as needed.
            this.tbl_transportadoraTableAdapter.Fill(this.pORTARIADataSet.tbl_transportadora);
           
        }
        private bool valida()
        {
            if (int.Parse(dtpInicial.Value.ToString("yyyyMMdd")) > int.Parse(dtpFinal.Value.ToString("yyyyMMdd")))
            {
                MessageBox.Show("Data inicial não pode ser maior que a final.", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                return false;
            }
            return true;
        }

        private void gerar()
        {
            
           
            string dataInicial,dataFinal, local, transportadora,placa;


            dataInicial = dtpInicial.Value.ToString("yyyyMMddHHmmss");
            dataFinal = dtpFinal.Value.ToString("yyyyMMddHHmmss");
            local = localcombo.SelectedValue.ToString();
            transportadora = transcombo.SelectedValue.ToString();
            placa = placamsktxt.Text.ToString().Trim();

            if (placa == "-")
            {
                placa = "";
            }

            frmViewrptCarga frm = new frmViewrptCarga();
            frm.dataInicial = dataInicial;
            frm.dataFinal = dataFinal;
            frm.local = local;
            frm.transportadora = transportadora;
            frm.placa = placa;

            if (entmercradio.Checked)
            {
                frm.opcaoRpt = "entMerc";
            }
            else
            {
                frm.opcaoRpt = "saiMerc";
            }

            frm.ShowDialog();
        }

        private void btnGerar_Click(object sender, EventArgs e)
        {
            if (valida())
            { gerar(); }
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
