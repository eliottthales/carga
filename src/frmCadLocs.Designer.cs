namespace Carga
{
    partial class frmCadLocs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadLocs));
            this.tabControl = new System.Windows.Forms.TabControl();
            this.Consulta = new System.Windows.Forms.TabPage();
            this.GridLocais = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tipotxt = new System.Windows.Forms.TextBox();
            this.endtxt = new System.Windows.Forms.TextBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.tipolbl = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.deslbl = new System.Windows.Forms.Label();
            this.loclbl = new System.Windows.Forms.Label();
            this.idlocaisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.localidadeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descricaoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tbl_locaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pORTARIADataSet = new Carga.PORTARIADataSet();
            this.tbl_locaisTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_locaisTableAdapter();
            this.tableAdapterManager = new Carga.PORTARIADataSetTableAdapters.TableAdapterManager();
            this.tbl_residuoTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_residuoTableAdapter();
            this.tblresiduoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tabControl.SuspendLayout();
            this.Consulta.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridLocais)).BeginInit();
            this.Cadastro.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_locaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblresiduoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.Consulta);
            this.tabControl.Controls.Add(this.Cadastro);
            this.tabControl.Location = new System.Drawing.Point(3, 3);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(368, 317);
            this.tabControl.TabIndex = 0;
            this.tabControl.SelectedIndexChanged += new System.EventHandler(this.tabControl_SelectedIndexChanged);
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.GridLocais);
            this.Consulta.Controls.Add(this.btnSair);
            this.Consulta.Controls.Add(this.btnEditar);
            this.Consulta.Controls.Add(this.btnInserir);
            this.Consulta.Location = new System.Drawing.Point(4, 22);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta.Size = new System.Drawing.Size(360, 291);
            this.Consulta.TabIndex = 0;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // GridLocais
            // 
            this.GridLocais.AllowUserToAddRows = false;
            this.GridLocais.AllowUserToDeleteRows = false;
            this.GridLocais.AutoGenerateColumns = false;
            this.GridLocais.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridLocais.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idlocaisDataGridViewTextBoxColumn,
            this.localidadeDataGridViewTextBoxColumn,
            this.descricaoDataGridViewTextBoxColumn,
            this.tipoDataGridViewTextBoxColumn});
            this.GridLocais.DataSource = this.tbl_locaisBindingSource;
            this.GridLocais.Location = new System.Drawing.Point(3, 6);
            this.GridLocais.Name = "GridLocais";
            this.GridLocais.ReadOnly = true;
            this.GridLocais.Size = new System.Drawing.Size(353, 245);
            this.GridLocais.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(279, 257);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 3;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(198, 256);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Location = new System.Drawing.Point(117, 256);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 1;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.comboBox1);
            this.Cadastro.Controls.Add(this.pictureBox1);
            this.Cadastro.Controls.Add(this.btnCancelar);
            this.Cadastro.Controls.Add(this.tipotxt);
            this.Cadastro.Controls.Add(this.endtxt);
            this.Cadastro.Controls.Add(this.nometxt);
            this.Cadastro.Controls.Add(this.tipolbl);
            this.Cadastro.Controls.Add(this.btnSalvar);
            this.Cadastro.Controls.Add(this.deslbl);
            this.Cadastro.Controls.Add(this.loclbl);
            this.Cadastro.Location = new System.Drawing.Point(4, 22);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(360, 291);
            this.Cadastro.TabIndex = 1;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 216);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(356, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 8;
            this.pictureBox1.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(87, 132);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tipotxt
            // 
            this.tipotxt.Location = new System.Drawing.Point(6, 106);
            this.tipotxt.Name = "tipotxt";
            this.tipotxt.Size = new System.Drawing.Size(353, 20);
            this.tipotxt.TabIndex = 6;
            // 
            // endtxt
            // 
            this.endtxt.Location = new System.Drawing.Point(5, 67);
            this.endtxt.Name = "endtxt";
            this.endtxt.Size = new System.Drawing.Size(354, 20);
            this.endtxt.TabIndex = 5;
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(5, 28);
            this.nometxt.Name = "nometxt";
            this.nometxt.Size = new System.Drawing.Size(354, 20);
            this.nometxt.TabIndex = 4;
            // 
            // tipolbl
            // 
            this.tipolbl.AutoSize = true;
            this.tipolbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tipolbl.Location = new System.Drawing.Point(6, 90);
            this.tipolbl.Name = "tipolbl";
            this.tipolbl.Size = new System.Drawing.Size(33, 15);
            this.tipolbl.TabIndex = 3;
            this.tipolbl.Text = "Tipo:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(6, 132);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // deslbl
            // 
            this.deslbl.AutoSize = true;
            this.deslbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.deslbl.Location = new System.Drawing.Point(5, 51);
            this.deslbl.Name = "deslbl";
            this.deslbl.Size = new System.Drawing.Size(58, 15);
            this.deslbl.TabIndex = 1;
            this.deslbl.Text = "Endereço:";
            // 
            // loclbl
            // 
            this.loclbl.AutoSize = true;
            this.loclbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.loclbl.Location = new System.Drawing.Point(5, 12);
            this.loclbl.Name = "loclbl";
            this.loclbl.Size = new System.Drawing.Size(64, 15);
            this.loclbl.TabIndex = 0;
            this.loclbl.Text = "Localidade:";
            // 
            // idlocaisDataGridViewTextBoxColumn
            // 
            this.idlocaisDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.idlocaisDataGridViewTextBoxColumn.DataPropertyName = "id_locais";
            this.idlocaisDataGridViewTextBoxColumn.HeaderText = "N° Reg";
            this.idlocaisDataGridViewTextBoxColumn.Name = "idlocaisDataGridViewTextBoxColumn";
            this.idlocaisDataGridViewTextBoxColumn.ReadOnly = true;
            this.idlocaisDataGridViewTextBoxColumn.Visible = false;
            this.idlocaisDataGridViewTextBoxColumn.Width = 5;
            // 
            // localidadeDataGridViewTextBoxColumn
            // 
            this.localidadeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.localidadeDataGridViewTextBoxColumn.DataPropertyName = "localidade";
            this.localidadeDataGridViewTextBoxColumn.HeaderText = "Localidade";
            this.localidadeDataGridViewTextBoxColumn.Name = "localidadeDataGridViewTextBoxColumn";
            this.localidadeDataGridViewTextBoxColumn.ReadOnly = true;
            this.localidadeDataGridViewTextBoxColumn.Width = 84;
            // 
            // descricaoDataGridViewTextBoxColumn
            // 
            this.descricaoDataGridViewTextBoxColumn.DataPropertyName = "descricao";
            this.descricaoDataGridViewTextBoxColumn.HeaderText = "Descrição";
            this.descricaoDataGridViewTextBoxColumn.Name = "descricaoDataGridViewTextBoxColumn";
            this.descricaoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tipoDataGridViewTextBoxColumn
            // 
            this.tipoDataGridViewTextBoxColumn.DataPropertyName = "tipo";
            this.tipoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoDataGridViewTextBoxColumn.Name = "tipoDataGridViewTextBoxColumn";
            this.tipoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tbl_locaisBindingSource
            // 
            this.tbl_locaisBindingSource.DataMember = "tbl_locais";
            this.tbl_locaisBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // pORTARIADataSet
            // 
            this.pORTARIADataSet.DataSetName = "PORTARIADataSet";
            this.pORTARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_locaisTableAdapter
            // 
            this.tbl_locaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_ambTableAdapter = null;
            this.tableAdapterManager.tbl_entrada_MercadoriaTableAdapter = null;
            this.tableAdapterManager.tbl_fiorinoTableAdapter = null;
            this.tableAdapterManager.tbl_locaisTableAdapter = this.tbl_locaisTableAdapter;
            this.tableAdapterManager.tbl_partTableAdapter = null;
            this.tableAdapterManager.tbl_residuoTableAdapter = this.tbl_residuoTableAdapter;
            this.tableAdapterManager.tbl_saida_MercadoriaTableAdapter = null;
            this.tableAdapterManager.tbl_transportadoraTableAdapter = null;
            this.tableAdapterManager.tbl_userTableAdapter = null;
            this.tableAdapterManager.tbl_visitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Carga.PORTARIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_residuoTableAdapter
            // 
            this.tbl_residuoTableAdapter.ClearBeforeFill = true;
            // 
            // tblresiduoBindingSource
            // 
            this.tblresiduoBindingSource.DataMember = "tbl_residuo";
            this.tblresiduoBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 173);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(156, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // frmCadLocs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 321);
            this.Controls.Add(this.tabControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadLocs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Locais";
            this.Load += new System.EventHandler(this.frmCadLocs_Load);
            this.tabControl.ResumeLayout(false);
            this.Consulta.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridLocais)).EndInit();
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_locaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblresiduoBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PORTARIADataSet pORTARIADataSet;
        private System.Windows.Forms.BindingSource tbl_locaisBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_locaisTableAdapter tbl_locaisTableAdapter;
        private Carga.PORTARIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.DataGridView GridLocais;
        private Carga.PORTARIADataSetTableAdapters.tbl_residuoTableAdapter tbl_residuoTableAdapter;
        private System.Windows.Forms.BindingSource tblresiduoBindingSource;
        private System.Windows.Forms.Label deslbl;
        private System.Windows.Forms.Label loclbl;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox tipotxt;
        private System.Windows.Forms.TextBox endtxt;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.Label tipolbl;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idlocaisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn localidadeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descricaoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoDataGridViewTextBoxColumn;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
