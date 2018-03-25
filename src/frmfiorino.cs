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
    public partial class frmfiorino : Form
    {
        public frmfiorino()
        {
            InitializeComponent();
        }

        private void tbl_fiorinoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tbl_fiorinoBindingSource.EndEdit();
                
                MessageBox.Show("Registro salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao salvar registro!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmfiorino_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_fiorino' table. You can move, or remove it, as needed.
            

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_fiorinoBindingSource.EndEdit();
            
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.tbl_fiorinoBindingSource.EndEdit();
                
            }
            else
            {
                
            }
        }
    }
}
