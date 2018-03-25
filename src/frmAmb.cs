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
    public partial class frmAmb : Form
    {
        public frmAmb()
        {
            InitializeComponent();
        }

        private void tbl_ambBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.tbl_ambBindingSource.EndEdit();
              
                MessageBox.Show("Registro salvo com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception)
            {
                MessageBox.Show("Falha ao salvar registro!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void frmAmb_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'pORTARIADataSet.tbl_amb' table. You can move, or remove it, as needed.
           
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tbl_ambBindingSource.EndEdit();
           
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Excluir o Registro?", "Atenção!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Validate();
                this.tbl_ambBindingSource.EndEdit();
                
            }
            else
            {
                
            }
        }
    }
}
