namespace Carga
{
    partial class frmPart
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
            this.tbl_partBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pORTARIADataSet = new Carga.PORTARIADataSet();
            this.tableAdapterManager = new Carga.PORTARIADataSetTableAdapters.TableAdapterManager();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.modelotxt = new System.Windows.Forms.TextBox();
            this.cnhtxt = new System.Windows.Forms.TextBox();
            this.nometxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.dtphorasai = new System.Windows.Forms.DateTimePicker();
            this.dtphoraent = new System.Windows.Forms.DateTimePicker();
            this.placamsktxt = new System.Windows.Forms.MaskedTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpdata = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.consultaDataSet = new Carga.ConsultaDataSet();
            this.tbl_cad_FuncBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_cad_FuncTableAdapter = new Carga.ConsultaDataSetTableAdapters.tbl_cad_FuncTableAdapter();
            this.tbl_partTableAdapter = new Carga.ConsultaDataSetTableAdapters.tbl_partTableAdapter();
            this.tbl_partBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Carga.ConsultaDataSetTableAdapters.TableAdapterManager();
            this.tbl_partDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cad_FuncBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // tbl_partBindingSource
            // 
            this.tbl_partBindingSource.DataMember = "tbl_part";
            this.tbl_partBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // pORTARIADataSet
            // 
            this.pORTARIADataSet.DataSetName = "PORTARIADataSet";
            this.pORTARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.tbl_ambTableAdapter = null;
            this.tableAdapterManager.tbl_entrada_MercadoriaTableAdapter = null;
            this.tableAdapterManager.tbl_fiorinoTableAdapter = null;
            this.tableAdapterManager.tbl_locaisTableAdapter = null;
            this.tableAdapterManager.tbl_partTableAdapter = null;
            this.tableAdapterManager.tbl_residuoTableAdapter = null;
            this.tableAdapterManager.tbl_saida_MercadoriaTableAdapter = null;
            this.tableAdapterManager.tbl_transportadoraTableAdapter = null;
            this.tableAdapterManager.tbl_userTableAdapter = null;
            this.tableAdapterManager.tbl_visitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Carga.PORTARIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "CNH:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Placa:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "Modelo:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.modelotxt);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cnhtxt);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nometxt);
            this.groupBox1.Location = new System.Drawing.Point(242, 20);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(194, 127);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            // 
            // modelotxt
            // 
            this.modelotxt.Location = new System.Drawing.Point(68, 80);
            this.modelotxt.Name = "modelotxt";
            this.modelotxt.ReadOnly = true;
            this.modelotxt.Size = new System.Drawing.Size(106, 20);
            this.modelotxt.TabIndex = 6;
            // 
            // cnhtxt
            // 
            this.cnhtxt.Location = new System.Drawing.Point(68, 53);
            this.cnhtxt.Name = "cnhtxt";
            this.cnhtxt.ReadOnly = true;
            this.cnhtxt.Size = new System.Drawing.Size(106, 20);
            this.cnhtxt.TabIndex = 5;
            // 
            // nometxt
            // 
            this.nometxt.Location = new System.Drawing.Point(68, 24);
            this.nometxt.Name = "nometxt";
            this.nometxt.ReadOnly = true;
            this.nometxt.Size = new System.Drawing.Size(106, 20);
            this.nometxt.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnConsulta);
            this.groupBox2.Controls.Add(this.dtphorasai);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.dtphoraent);
            this.groupBox2.Controls.Add(this.placamsktxt);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.dtpdata);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(453, 184);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(158, 20);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(24, 20);
            this.btnConsulta.TabIndex = 14;
            this.btnConsulta.Text = "...";
            this.btnConsulta.UseVisualStyleBackColor = true;
            // 
            // dtphorasai
            // 
            this.dtphorasai.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphorasai.Location = new System.Drawing.Point(68, 114);
            this.dtphorasai.Name = "dtphorasai";
            this.dtphorasai.Size = new System.Drawing.Size(83, 20);
            this.dtphorasai.TabIndex = 3;
            // 
            // dtphoraent
            // 
            this.dtphoraent.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtphoraent.Location = new System.Drawing.Point(68, 80);
            this.dtphoraent.Name = "dtphoraent";
            this.dtphoraent.Size = new System.Drawing.Size(83, 20);
            this.dtphoraent.TabIndex = 2;
            // 
            // placamsktxt
            // 
            this.placamsktxt.Location = new System.Drawing.Point(68, 20);
            this.placamsktxt.Mask = ">?>?>?-####";
            this.placamsktxt.Name = "placamsktxt";
            this.placamsktxt.Size = new System.Drawing.Size(83, 20);
            this.placamsktxt.TabIndex = 0;
            this.placamsktxt.Leave += new System.EventHandler(this.placamsktxt_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 114);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Saída:";
            // 
            // dtpdata
            // 
            this.dtpdata.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpdata.Location = new System.Drawing.Point(68, 51);
            this.dtpdata.Name = "dtpdata";
            this.dtpdata.Size = new System.Drawing.Size(83, 20);
            this.dtpdata.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Entrada:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 55);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Data:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(309, 448);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(390, 448);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // consultaDataSet
            // 
            this.consultaDataSet.DataSetName = "ConsultaDataSet";
            this.consultaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_cad_FuncBindingSource
            // 
            this.tbl_cad_FuncBindingSource.DataMember = "tbl_cad_Func";
            this.tbl_cad_FuncBindingSource.DataSource = this.consultaDataSet;
            // 
            // tbl_cad_FuncTableAdapter
            // 
            this.tbl_cad_FuncTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_partTableAdapter
            // 
            this.tbl_partTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_partBindingSource1
            // 
            this.tbl_partBindingSource1.DataMember = "tbl_part";
            this.tbl_partBindingSource1.DataSource = this.consultaDataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbl_cad_FuncTableAdapter = this.tbl_cad_FuncTableAdapter;
            this.tableAdapterManager1.tbl_entrada_MercadoriaTableAdapter = null;
            this.tableAdapterManager1.tbl_locaisTableAdapter = null;
            this.tableAdapterManager1.tbl_partTableAdapter = this.tbl_partTableAdapter;
            this.tableAdapterManager1.tbl_residuoTableAdapter = null;
            this.tableAdapterManager1.tbl_saida_MercadoriaTableAdapter = null;
            this.tableAdapterManager1.tbl_transportadoraTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Carga.ConsultaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_partDataGridView
            // 
            this.tbl_partDataGridView.AutoGenerateColumns = false;
            this.tbl_partDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_partDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tbl_partDataGridView.DataSource = this.tbl_partBindingSource1;
            this.tbl_partDataGridView.Location = new System.Drawing.Point(12, 217);
            this.tbl_partDataGridView.Name = "tbl_partDataGridView";
            this.tbl_partDataGridView.Size = new System.Drawing.Size(453, 153);
            this.tbl_partDataGridView.TabIndex = 9;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "placa_veiculo";
            this.dataGridViewTextBoxColumn1.HeaderText = "placa_veiculo";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "data_ent";
            this.dataGridViewTextBoxColumn2.HeaderText = "data_ent";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "data_sai";
            this.dataGridViewTextBoxColumn3.HeaderText = "data_sai";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // frmPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 476);
            this.Controls.Add(this.tbl_partDataGridView);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.groupBox2);
            this.Name = "frmPart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Controle de Veículos";
            this.Load += new System.EventHandler(this.frmPart_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_cad_FuncBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_partDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PORTARIADataSet pORTARIADataSet;
        private System.Windows.Forms.BindingSource tbl_partBindingSource;

        private Carga.PORTARIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox cnhtxt;
        private System.Windows.Forms.TextBox nometxt;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox placamsktxt;
        private System.Windows.Forms.DateTimePicker dtpdata;
        private System.Windows.Forms.DateTimePicker dtphoraent;
        private System.Windows.Forms.DateTimePicker dtphorasai;
        private System.Windows.Forms.TextBox modelotxt;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnSair;
        private ConsultaDataSet consultaDataSet;
        private System.Windows.Forms.BindingSource tbl_cad_FuncBindingSource;
        private Carga.ConsultaDataSetTableAdapters.tbl_cad_FuncTableAdapter tbl_cad_FuncTableAdapter;
        private Carga.ConsultaDataSetTableAdapters.tbl_partTableAdapter tbl_partTableAdapter;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.BindingSource tbl_partBindingSource1;
        private Carga.ConsultaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.DataGridView tbl_partDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}
