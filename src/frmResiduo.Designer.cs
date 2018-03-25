namespace Carga
{
    partial class frmResiduo
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
            System.Windows.Forms.Label datalbl;
            System.Windows.Forms.Label nfLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label id_transportadoraLabel;
            System.Windows.Forms.Label locais_destinoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResiduo));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.localcombo = new System.Windows.Forms.ComboBox();
            this.tbllocaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pORTARIADataSet = new Carga.PORTARIADataSet();
            this.transcombo = new System.Windows.Forms.ComboBox();
            this.tbltransportadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.serietxt = new System.Windows.Forms.TextBox();
            this.nftxt = new System.Windows.Forms.TextBox();
            this.placamsktxtlbl = new System.Windows.Forms.Label();
            this.placamasktxt = new System.Windows.Forms.MaskedTextBox();
            this.horalbl = new System.Windows.Forms.Label();
            this.timePicker = new System.Windows.Forms.DateTimePicker();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.mottxt = new System.Windows.Forms.TextBox();
            this.motlbl = new System.Windows.Forms.Label();
            this.tbl_residuoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridResiduos = new System.Windows.Forms.DataGridView();
            this.id_residuo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tbl_residuoTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_residuoTableAdapter();
            this.tableAdapterManager = new Carga.PORTARIADataSetTableAdapters.TableAdapterManager();
            this.tbl_locaisTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_locaisTableAdapter();
            this.tbl_transportadoraTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_transportadoraTableAdapter();
            datalbl = new System.Windows.Forms.Label();
            nfLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            id_transportadoraLabel = new System.Windows.Forms.Label();
            locais_destinoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransportadoraBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_residuoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridResiduos)).BeginInit();
            this.SuspendLayout();
            // 
            // datalbl
            // 
            datalbl.AutoSize = true;
            datalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            datalbl.Location = new System.Drawing.Point(6, 67);
            datalbl.Name = "datalbl";
            datalbl.Size = new System.Drawing.Size(78, 13);
            datalbl.TabIndex = 5;
            datalbl.Text = "Data de Saida:";
            // 
            // nfLabel
            // 
            nfLabel.AutoSize = true;
            nfLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nfLabel.Location = new System.Drawing.Point(6, 25);
            nfLabel.Name = "nfLabel";
            nfLabel.Size = new System.Drawing.Size(63, 13);
            nfLabel.TabIndex = 1;
            nfLabel.Text = "Nota Fiscal:";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serieLabel.Location = new System.Drawing.Point(174, 25);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(34, 13);
            serieLabel.TabIndex = 3;
            serieLabel.Text = "Série:";
            // 
            // id_transportadoraLabel
            // 
            id_transportadoraLabel.AutoSize = true;
            id_transportadoraLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_transportadoraLabel.Location = new System.Drawing.Point(174, 107);
            id_transportadoraLabel.Name = "id_transportadoraLabel";
            id_transportadoraLabel.Size = new System.Drawing.Size(82, 13);
            id_transportadoraLabel.TabIndex = 11;
            id_transportadoraLabel.Text = "Transportadora:";
            // 
            // locais_destinoLabel
            // 
            locais_destinoLabel.AutoSize = true;
            locais_destinoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locais_destinoLabel.Location = new System.Drawing.Point(6, 107);
            locais_destinoLabel.Name = "locais_destinoLabel";
            locais_destinoLabel.Size = new System.Drawing.Size(46, 13);
            locais_destinoLabel.TabIndex = 9;
            locais_destinoLabel.Text = "Destino:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(this.localcombo);
            this.groupBox1.Controls.Add(this.transcombo);
            this.groupBox1.Controls.Add(locais_destinoLabel);
            this.groupBox1.Controls.Add(id_transportadoraLabel);
            this.groupBox1.Controls.Add(serieLabel);
            this.groupBox1.Controls.Add(this.serietxt);
            this.groupBox1.Controls.Add(nfLabel);
            this.groupBox1.Controls.Add(this.nftxt);
            this.groupBox1.Controls.Add(this.placamsktxtlbl);
            this.groupBox1.Controls.Add(this.placamasktxt);
            this.groupBox1.Controls.Add(this.horalbl);
            this.groupBox1.Controls.Add(this.timePicker);
            this.groupBox1.Controls.Add(datalbl);
            this.groupBox1.Controls.Add(this.datePicker);
            this.groupBox1.Controls.Add(this.mottxt);
            this.groupBox1.Controls.Add(this.motlbl);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(310, 287);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(204, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(92, 21);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(106, 260);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(92, 21);
            this.btnEditar.TabIndex = 18;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(9, 260);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 21);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // localcombo
            // 
            this.localcombo.DataSource = this.tbllocaisBindingSource;
            this.localcombo.DisplayMember = "localidade";
            this.localcombo.FormattingEnabled = true;
            this.localcombo.Location = new System.Drawing.Point(9, 123);
            this.localcombo.Name = "localcombo";
            this.localcombo.Size = new System.Drawing.Size(108, 21);
            this.localcombo.TabIndex = 10;
            this.localcombo.ValueMember = "id_locais";
            // 
            // tbllocaisBindingSource
            // 
            this.tbllocaisBindingSource.DataMember = "tbl_locais";
            this.tbllocaisBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // pORTARIADataSet
            // 
            this.pORTARIADataSet.DataSetName = "PORTARIADataSet";
            this.pORTARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // transcombo
            // 
            this.transcombo.DataSource = this.tbltransportadoraBindingSource;
            this.transcombo.DisplayMember = "transportadora";
            this.transcombo.FormattingEnabled = true;
            this.transcombo.Location = new System.Drawing.Point(176, 123);
            this.transcombo.Name = "transcombo";
            this.transcombo.Size = new System.Drawing.Size(109, 21);
            this.transcombo.TabIndex = 12;
            this.transcombo.ValueMember = "id_transportadora";
            // 
            // tbltransportadoraBindingSource
            // 
            this.tbltransportadoraBindingSource.DataMember = "tbl_transportadora";
            this.tbltransportadoraBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // serietxt
            // 
            this.serietxt.Location = new System.Drawing.Point(178, 42);
            this.serietxt.Name = "serietxt";
            this.serietxt.Size = new System.Drawing.Size(50, 20);
            this.serietxt.TabIndex = 4;
            this.serietxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serietxt_KeyPress);
            // 
            // nftxt
            // 
            this.nftxt.Location = new System.Drawing.Point(9, 42);
            this.nftxt.Name = "nftxt";
            this.nftxt.Size = new System.Drawing.Size(109, 20);
            this.nftxt.TabIndex = 2;
            this.nftxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nftxt_KeyPress);
            // 
            // placamsktxtlbl
            // 
            this.placamsktxtlbl.AutoSize = true;
            this.placamsktxtlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.placamsktxtlbl.Location = new System.Drawing.Point(174, 147);
            this.placamsktxtlbl.Name = "placamsktxtlbl";
            this.placamsktxtlbl.Size = new System.Drawing.Size(90, 13);
            this.placamsktxtlbl.TabIndex = 15;
            this.placamsktxtlbl.Text = "Placa do Veiculo:";
            // 
            // placamasktxt
            // 
            this.placamasktxt.Location = new System.Drawing.Point(176, 163);
            this.placamasktxt.Mask = ">?>?>?-####";
            this.placamasktxt.Name = "placamasktxt";
            this.placamasktxt.Size = new System.Drawing.Size(109, 20);
            this.placamasktxt.TabIndex = 16;
            // 
            // horalbl
            // 
            this.horalbl.AutoSize = true;
            this.horalbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.horalbl.Location = new System.Drawing.Point(174, 67);
            this.horalbl.Name = "horalbl";
            this.horalbl.Size = new System.Drawing.Size(80, 13);
            this.horalbl.TabIndex = 7;
            this.horalbl.Text = "Hora de Saída:";
            // 
            // timePicker
            // 
            this.timePicker.CustomFormat = "HH:mm:ss";
            this.timePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.timePicker.Location = new System.Drawing.Point(177, 84);
            this.timePicker.Name = "timePicker";
            this.timePicker.ShowUpDown = true;
            this.timePicker.Size = new System.Drawing.Size(108, 20);
            this.timePicker.TabIndex = 8;
            // 
            // datePicker
            // 
            this.datePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.datePicker.Location = new System.Drawing.Point(9, 84);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(109, 20);
            this.datePicker.TabIndex = 6;
            // 
            // mottxt
            // 
            this.mottxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.mottxt.Location = new System.Drawing.Point(9, 163);
            this.mottxt.Name = "mottxt";
            this.mottxt.Size = new System.Drawing.Size(108, 20);
            this.mottxt.TabIndex = 14;
            // 
            // motlbl
            // 
            this.motlbl.AutoSize = true;
            this.motlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motlbl.Location = new System.Drawing.Point(6, 147);
            this.motlbl.Name = "motlbl";
            this.motlbl.Size = new System.Drawing.Size(53, 13);
            this.motlbl.TabIndex = 13;
            this.motlbl.Text = "Motorista:";
            // 
            // tbl_residuoBindingSource
            // 
            this.tbl_residuoBindingSource.DataMember = "tbl_residuo";
            this.tbl_residuoBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(328, 287);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridResiduos);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 301);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(644, 301);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrados";
            // 
            // GridResiduos
            // 
            this.GridResiduos.AllowUserToAddRows = false;
            this.GridResiduos.AllowUserToDeleteRows = false;
            this.GridResiduos.AutoGenerateColumns = false;
            this.GridResiduos.BackgroundColor = System.Drawing.Color.White;
            this.GridResiduos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridResiduos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_residuo,
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.GridResiduos.DataSource = this.tbl_residuoBindingSource;
            this.GridResiduos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridResiduos.Location = new System.Drawing.Point(3, 16);
            this.GridResiduos.Name = "GridResiduos";
            this.GridResiduos.ReadOnly = true;
            this.GridResiduos.Size = new System.Drawing.Size(638, 282);
            this.GridResiduos.TabIndex = 21;
            // 
            // id_residuo
            // 
            this.id_residuo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            this.id_residuo.DataPropertyName = "id_residuo";
            this.id_residuo.HeaderText = "N° Reg";
            this.id_residuo.Name = "id_residuo";
            this.id_residuo.ReadOnly = true;
            this.id_residuo.Width = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn1.DataPropertyName = "data";
            this.dataGridViewTextBoxColumn1.HeaderText = "Data";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 59;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn2.DataPropertyName = "placa_veiculo";
            this.dataGridViewTextBoxColumn2.HeaderText = "Placa do Veiculo";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 117;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn3.DataPropertyName = "motorista";
            this.dataGridViewTextBoxColumn3.HeaderText = "Motorista";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 84;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn4.DataPropertyName = "nf";
            this.dataGridViewTextBoxColumn4.HeaderText = "Nota Fiscal";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 88;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn5.DataPropertyName = "serie";
            this.dataGridViewTextBoxColumn5.HeaderText = "Série";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 61;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn6.DataPropertyName = "id_transportadora";
            this.dataGridViewTextBoxColumn6.DataSource = this.tbltransportadoraBindingSource;
            this.dataGridViewTextBoxColumn6.DisplayMember = "transportadora";
            this.dataGridViewTextBoxColumn6.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn6.HeaderText = "Transportadora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn6.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn6.ValueMember = "id_transportadora";
            this.dataGridViewTextBoxColumn6.Width = 118;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewTextBoxColumn7.DataPropertyName = "locais_destino";
            this.dataGridViewTextBoxColumn7.DataSource = this.tbllocaisBindingSource;
            this.dataGridViewTextBoxColumn7.DisplayMember = "localidade";
            this.dataGridViewTextBoxColumn7.DisplayStyle = System.Windows.Forms.DataGridViewComboBoxDisplayStyle.Nothing;
            this.dataGridViewTextBoxColumn7.HeaderText = "Destino";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn7.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn7.ValueMember = "id_locais";
            this.dataGridViewTextBoxColumn7.Width = 75;
            // 
            // tbl_residuoTableAdapter
            // 
            this.tbl_residuoTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.tbl_transportadoraTableAdapter = this.tbl_transportadoraTableAdapter;
            this.tableAdapterManager.tbl_userTableAdapter = null;
            this.tableAdapterManager.tbl_visitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Carga.PORTARIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_locaisTableAdapter
            // 
            this.tbl_locaisTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_transportadoraTableAdapter
            // 
            this.tbl_transportadoraTableAdapter.ClearBeforeFill = true;
            // 
            // frmResiduo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 602);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmResiduo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Saída de Resíduos";
            this.Load += new System.EventHandler(this.frmResiduo_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransportadoraBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_residuoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridResiduos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PORTARIADataSet pORTARIADataSet;
        private System.Windows.Forms.BindingSource tbl_residuoBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_residuoTableAdapter tbl_residuoTableAdapter;
        private Carga.PORTARIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private Carga.PORTARIADataSetTableAdapters.tbl_transportadoraTableAdapter tbl_transportadoraTableAdapter;
        private System.Windows.Forms.BindingSource tbltransportadoraBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_locaisTableAdapter tbl_locaisTableAdapter;
        private System.Windows.Forms.BindingSource tbllocaisBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox mottxt;
        private System.Windows.Forms.Label motlbl;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.Label horalbl;
        private System.Windows.Forms.DateTimePicker timePicker;
        private System.Windows.Forms.Label placamsktxtlbl;
        private System.Windows.Forms.MaskedTextBox placamasktxt;
        private System.Windows.Forms.TextBox serietxt;
        private System.Windows.Forms.TextBox nftxt;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView GridResiduos;
        private System.Windows.Forms.ComboBox transcombo;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.ComboBox localcombo;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_residuo;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn7;
    }
}
