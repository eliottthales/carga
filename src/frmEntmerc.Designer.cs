namespace Carga
{
    partial class frmEntmerc
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
            System.Windows.Forms.Label data_entradaLabel;
            System.Windows.Forms.Label hora_entradaLabel;
            System.Windows.Forms.Label locais_origemLabel;
            System.Windows.Forms.Label nfLabel;
            System.Windows.Forms.Label serieLabel;
            System.Windows.Forms.Label motoristaLabel;
            System.Windows.Forms.Label placa_veiculoLabel;
            System.Windows.Forms.Label responsavel_entradaLabel;
            System.Windows.Forms.Label id_transportadoraLabel1;
            System.Windows.Forms.Label obsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEntmerc));
            this.tblentradaMercadoriaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pORTARIADataSet = new Carga.PORTARIADataSet();
            this.localcombo = new System.Windows.Forms.ComboBox();
            this.consultaDataSet = new Carga.ConsultaDataSet();
            this.tbllocaisBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbllocaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.nftxt = new System.Windows.Forms.TextBox();
            this.serietxt = new System.Windows.Forms.TextBox();
            this.motoristatxt = new System.Windows.Forms.TextBox();
            this.placamsktxt = new System.Windows.Forms.MaskedTextBox();
            this.responsaveltxt = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.obstxt = new System.Windows.Forms.TextBox();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.transcombo = new System.Windows.Forms.ComboBox();
            this.tbltransportadoraBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbltransportadoraBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GridEntradas = new System.Windows.Forms.DataGridView();
            this.tbl_entrada_MercadoriaTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_entrada_MercadoriaTableAdapter();
            this.tbl_transportadoraTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_transportadoraTableAdapter();
            this.tbl_locaisTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_locaisTableAdapter();
            this.tableAdapterManager = new Carga.PORTARIADataSetTableAdapters.TableAdapterManager();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tbl_gridEntrMercBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblentradaMercadoriaBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_gridEntrMercTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_gridEntrMercTableAdapter();
            this.tbl_locaisBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager1 = new Carga.ConsultaDataSetTableAdapters.TableAdapterManager();
            this.tbl_entrada_MercadoriaTableAdapter1 = new Carga.ConsultaDataSetTableAdapters.tbl_entrada_MercadoriaTableAdapter();
            this.tbl_locaisTableAdapter1 = new Carga.ConsultaDataSetTableAdapters.tbl_locaisTableAdapter();
            this.consultaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbllocaisBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            data_entradaLabel = new System.Windows.Forms.Label();
            hora_entradaLabel = new System.Windows.Forms.Label();
            locais_origemLabel = new System.Windows.Forms.Label();
            nfLabel = new System.Windows.Forms.Label();
            serieLabel = new System.Windows.Forms.Label();
            motoristaLabel = new System.Windows.Forms.Label();
            placa_veiculoLabel = new System.Windows.Forms.Label();
            responsavel_entradaLabel = new System.Windows.Forms.Label();
            id_transportadoraLabel1 = new System.Windows.Forms.Label();
            obsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tblentradaMercadoriaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransportadoraBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransportadoraBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridEntradas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_gridEntrMercBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblentradaMercadoriaBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_locaisBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // data_entradaLabel
            // 
            data_entradaLabel.AutoSize = true;
            data_entradaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            data_entradaLabel.Location = new System.Drawing.Point(6, 67);
            data_entradaLabel.Name = "data_entradaLabel";
            data_entradaLabel.Size = new System.Drawing.Size(100, 14);
            data_entradaLabel.TabIndex = 5;
            data_entradaLabel.Text = "Data de Entrada:";
            // 
            // hora_entradaLabel
            // 
            hora_entradaLabel.AutoSize = true;
            hora_entradaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            hora_entradaLabel.Location = new System.Drawing.Point(174, 67);
            hora_entradaLabel.Name = "hora_entradaLabel";
            hora_entradaLabel.Size = new System.Drawing.Size(100, 14);
            hora_entradaLabel.TabIndex = 7;
            hora_entradaLabel.Text = "Hora de Entrada:";
            // 
            // locais_origemLabel
            // 
            locais_origemLabel.AutoSize = true;
            locais_origemLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            locais_origemLabel.Location = new System.Drawing.Point(6, 107);
            locais_origemLabel.Name = "locais_origemLabel";
            locais_origemLabel.Size = new System.Drawing.Size(99, 14);
            locais_origemLabel.TabIndex = 9;
            locais_origemLabel.Text = "Local de Origem:";
            // 
            // nfLabel
            // 
            nfLabel.AutoSize = true;
            nfLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nfLabel.Location = new System.Drawing.Point(6, 25);
            nfLabel.Name = "nfLabel";
            nfLabel.Size = new System.Drawing.Size(68, 14);
            nfLabel.TabIndex = 1;
            nfLabel.Text = "Nota Fiscal:";
            // 
            // serieLabel
            // 
            serieLabel.AutoSize = true;
            serieLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serieLabel.Location = new System.Drawing.Point(174, 25);
            serieLabel.Name = "serieLabel";
            serieLabel.Size = new System.Drawing.Size(38, 14);
            serieLabel.TabIndex = 3;
            serieLabel.Text = "Série:";
            // 
            // motoristaLabel
            // 
            motoristaLabel.AutoSize = true;
            motoristaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            motoristaLabel.Location = new System.Drawing.Point(6, 149);
            motoristaLabel.Name = "motoristaLabel";
            motoristaLabel.Size = new System.Drawing.Size(61, 14);
            motoristaLabel.TabIndex = 13;
            motoristaLabel.Text = "Motorista:";
            // 
            // placa_veiculoLabel
            // 
            placa_veiculoLabel.AutoSize = true;
            placa_veiculoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            placa_veiculoLabel.Location = new System.Drawing.Point(175, 149);
            placa_veiculoLabel.Name = "placa_veiculoLabel";
            placa_veiculoLabel.Size = new System.Drawing.Size(99, 14);
            placa_veiculoLabel.TabIndex = 15;
            placa_veiculoLabel.Text = "Placa do Veiculo:";
            // 
            // responsavel_entradaLabel
            // 
            responsavel_entradaLabel.AutoSize = true;
            responsavel_entradaLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            responsavel_entradaLabel.Location = new System.Drawing.Point(6, 189);
            responsavel_entradaLabel.Name = "responsavel_entradaLabel";
            responsavel_entradaLabel.Size = new System.Drawing.Size(96, 14);
            responsavel_entradaLabel.TabIndex = 17;
            responsavel_entradaLabel.Text = "Resp. Liberação:";
            // 
            // id_transportadoraLabel1
            // 
            id_transportadoraLabel1.AutoSize = true;
            id_transportadoraLabel1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            id_transportadoraLabel1.Location = new System.Drawing.Point(175, 107);
            id_transportadoraLabel1.Name = "id_transportadoraLabel1";
            id_transportadoraLabel1.Size = new System.Drawing.Size(94, 14);
            id_transportadoraLabel1.TabIndex = 11;
            id_transportadoraLabel1.Text = "Transportadora:";
            // 
            // obsLabel
            // 
            obsLabel.AutoSize = true;
            obsLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            obsLabel.Location = new System.Drawing.Point(175, 190);
            obsLabel.Name = "obsLabel";
            obsLabel.Size = new System.Drawing.Size(74, 14);
            obsLabel.TabIndex = 21;
            obsLabel.Text = "Observação:";
            // 
            // tblentradaMercadoriaBindingSource
            // 
            this.tblentradaMercadoriaBindingSource.DataMember = "tbl_entrada_Mercadoria";
            this.tblentradaMercadoriaBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // pORTARIADataSet
            // 
            this.pORTARIADataSet.DataSetName = "PORTARIADataSet";
            this.pORTARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // localcombo
            // 
            this.localcombo.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.localcombo.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.localcombo.DisplayMember = "id_locais";
            this.localcombo.FormattingEnabled = true;
            this.localcombo.Location = new System.Drawing.Point(8, 124);
            this.localcombo.Name = "localcombo";
            this.localcombo.Size = new System.Drawing.Size(97, 21);
            this.localcombo.TabIndex = 10;
            this.localcombo.ValueMember = "id_locais";
            // 
            // consultaDataSet
            // 
            this.consultaDataSet.DataSetName = "ConsultaDataSet";
            this.consultaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbllocaisBindingSource1
            // 
            this.tbllocaisBindingSource1.DataMember = "tbl_locais";
            this.tbllocaisBindingSource1.DataSource = this.pORTARIADataSet;
            // 
            // tbllocaisBindingSource
            // 
            this.tbllocaisBindingSource.DataMember = "tbl_locais";
            this.tbllocaisBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // nftxt
            // 
            this.nftxt.Location = new System.Drawing.Point(9, 42);
            this.nftxt.Name = "nftxt";
            this.nftxt.Size = new System.Drawing.Size(97, 20);
            this.nftxt.TabIndex = 2;
            this.nftxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nftxt_KeyPress);
            // 
            // serietxt
            // 
            this.serietxt.Location = new System.Drawing.Point(178, 42);
            this.serietxt.Name = "serietxt";
            this.serietxt.Size = new System.Drawing.Size(50, 20);
            this.serietxt.TabIndex = 4;
            this.serietxt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.serietxt_KeyPress);
            // 
            // motoristatxt
            // 
            this.motoristatxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.motoristatxt.Location = new System.Drawing.Point(8, 166);
            this.motoristatxt.Name = "motoristatxt";
            this.motoristatxt.Size = new System.Drawing.Size(97, 20);
            this.motoristatxt.TabIndex = 14;
            // 
            // placamsktxt
            // 
            this.placamsktxt.Location = new System.Drawing.Point(178, 166);
            this.placamsktxt.Mask = ">?>?>?-####";
            this.placamsktxt.Name = "placamsktxt";
            this.placamsktxt.Size = new System.Drawing.Size(108, 20);
            this.placamsktxt.TabIndex = 16;
            // 
            // responsaveltxt
            // 
            this.responsaveltxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.responsaveltxt.Location = new System.Drawing.Point(8, 206);
            this.responsaveltxt.Name = "responsaveltxt";
            this.responsaveltxt.Size = new System.Drawing.Size(97, 20);
            this.responsaveltxt.TabIndex = 18;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(obsLabel);
            this.groupBox1.Controls.Add(this.obstxt);
            this.groupBox1.Controls.Add(this.dateTimePicker2);
            this.groupBox1.Controls.Add(this.dateTimePicker1);
            this.groupBox1.Controls.Add(this.btnCancelar);
            this.groupBox1.Controls.Add(this.btnEditar);
            this.groupBox1.Controls.Add(this.btnSalvar);
            this.groupBox1.Controls.Add(id_transportadoraLabel1);
            this.groupBox1.Controls.Add(this.transcombo);
            this.groupBox1.Controls.Add(this.nftxt);
            this.groupBox1.Controls.Add(this.responsaveltxt);
            this.groupBox1.Controls.Add(responsavel_entradaLabel);
            this.groupBox1.Controls.Add(this.placamsktxt);
            this.groupBox1.Controls.Add(placa_veiculoLabel);
            this.groupBox1.Controls.Add(this.motoristatxt);
            this.groupBox1.Controls.Add(motoristaLabel);
            this.groupBox1.Controls.Add(this.localcombo);
            this.groupBox1.Controls.Add(locais_origemLabel);
            this.groupBox1.Controls.Add(hora_entradaLabel);
            this.groupBox1.Controls.Add(data_entradaLabel);
            this.groupBox1.Controls.Add(nfLabel);
            this.groupBox1.Controls.Add(this.serietxt);
            this.groupBox1.Controls.Add(serieLabel);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(334, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(343, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cadastro";
            // 
            // obstxt
            // 
            this.obstxt.Location = new System.Drawing.Point(178, 206);
            this.obstxt.Name = "obstxt";
            this.obstxt.Size = new System.Drawing.Size(100, 20);
            this.obstxt.TabIndex = 22;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "HH:mm:ss";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker2.Location = new System.Drawing.Point(178, 84);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(108, 20);
            this.dateTimePicker2.TabIndex = 8;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(9, 84);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(97, 20);
            this.dateTimePicker1.TabIndex = 6;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(203, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 21);
            this.btnCancelar.TabIndex = 21;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(106, 260);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 21);
            this.btnEditar.TabIndex = 20;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(9, 260);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 21);
            this.btnSalvar.TabIndex = 19;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // transcombo
            // 
            this.transcombo.DataSource = this.tbltransportadoraBindingSource1;
            this.transcombo.DisplayMember = "transportadora";
            this.transcombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.transcombo.FormattingEnabled = true;
            this.transcombo.Location = new System.Drawing.Point(178, 124);
            this.transcombo.Name = "transcombo";
            this.transcombo.Size = new System.Drawing.Size(108, 21);
            this.transcombo.TabIndex = 12;
            this.transcombo.ValueMember = "id_transportadora";
            // 
            // tbltransportadoraBindingSource1
            // 
            this.tbltransportadoraBindingSource1.DataMember = "tbl_transportadora";
            this.tbltransportadoraBindingSource1.DataSource = this.pORTARIADataSet;
            // 
            // tbltransportadoraBindingSource
            // 
            this.tbltransportadoraBindingSource.DataMember = "tbl_transportadora";
            this.tbltransportadoraBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.GridEntradas);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 335);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(682, 247);
            this.groupBox2.TabIndex = 22;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Cadastrados";
            // 
            // GridEntradas
            // 
            this.GridEntradas.AllowUserToAddRows = false;
            this.GridEntradas.AllowUserToDeleteRows = false;
            this.GridEntradas.BackgroundColor = System.Drawing.Color.White;
            this.GridEntradas.Dock = System.Windows.Forms.DockStyle.Fill;
            this.GridEntradas.Location = new System.Drawing.Point(3, 16);
            this.GridEntradas.Name = "GridEntradas";
            this.GridEntradas.ReadOnly = true;
            this.GridEntradas.Size = new System.Drawing.Size(676, 228);
            this.GridEntradas.TabIndex = 26;
            // 
            // tbl_entrada_MercadoriaTableAdapter
            // 
            this.tbl_entrada_MercadoriaTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_transportadoraTableAdapter
            // 
            this.tbl_transportadoraTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_locaisTableAdapter
            // 
            this.tbl_locaisTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tbl_ambTableAdapter = null;
            this.tableAdapterManager.tbl_entrada_MercadoriaTableAdapter = this.tbl_entrada_MercadoriaTableAdapter;
            this.tableAdapterManager.tbl_fiorinoTableAdapter = null;
            this.tableAdapterManager.tbl_locaisTableAdapter = this.tbl_locaisTableAdapter;
            this.tableAdapterManager.tbl_partTableAdapter = null;
            this.tableAdapterManager.tbl_residuoTableAdapter = null;
            this.tableAdapterManager.tbl_saida_MercadoriaTableAdapter = null;
            this.tableAdapterManager.tbl_transportadoraTableAdapter = this.tbl_transportadoraTableAdapter;
            this.tableAdapterManager.tbl_userTableAdapter = null;
            this.tableAdapterManager.tbl_visitTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Carga.PORTARIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(315, 301);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 26;
            this.pictureBox1.TabStop = false;
            // 
            // tbl_gridEntrMercBindingSource
            // 
            this.tbl_gridEntrMercBindingSource.DataSource = this.pORTARIADataSet;
            this.tbl_gridEntrMercBindingSource.Position = 0;
            // 
            // tblentradaMercadoriaBindingSource1
            // 
            this.tblentradaMercadoriaBindingSource1.DataMember = "tbl_entrada_Mercadoria";
            this.tblentradaMercadoriaBindingSource1.DataSource = this.tbl_gridEntrMercBindingSource;
            // 
            // tbl_gridEntrMercTableAdapter
            // 
            this.tbl_gridEntrMercTableAdapter.ClearBeforeFill = true;
            // 
            // tbl_locaisBindingSource
            // 
            this.tbl_locaisBindingSource.DataMember = "tbl_locais";
            this.tbl_locaisBindingSource.DataSource = this.consultaDataSet;
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.tbl_cad_FuncTableAdapter = null;
            this.tableAdapterManager1.tbl_entrada_MercadoriaTableAdapter = this.tbl_entrada_MercadoriaTableAdapter1;
            this.tableAdapterManager1.tbl_locaisTableAdapter = this.tbl_locaisTableAdapter1;
            this.tableAdapterManager1.tbl_partTableAdapter = null;
            this.tableAdapterManager1.tbl_residuoTableAdapter = null;
            this.tableAdapterManager1.tbl_saida_MercadoriaTableAdapter = null;
            this.tableAdapterManager1.tbl_transportadoraTableAdapter = null;
            this.tableAdapterManager1.UpdateOrder = Carga.ConsultaDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_entrada_MercadoriaTableAdapter1
            // 
            this.tbl_entrada_MercadoriaTableAdapter1.ClearBeforeFill = true;
            // 
            // tbl_locaisTableAdapter1
            // 
            this.tbl_locaisTableAdapter1.ClearBeforeFill = true;
            // 
            // consultaDataSetBindingSource
            // 
            this.consultaDataSetBindingSource.DataSource = this.consultaDataSet;
            this.consultaDataSetBindingSource.Position = 0;
            // 
            // tbllocaisBindingSource2
            // 
            this.tbllocaisBindingSource2.DataMember = "tbl_locais";
            this.tbllocaisBindingSource2.DataSource = this.tbl_gridEntrMercBindingSource;
            // 
            // frmEntmerc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(682, 582);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmEntmerc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada de Mercadoria";
            this.Load += new System.EventHandler(this.ent_merc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tblentradaMercadoriaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransportadoraBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbltransportadoraBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridEntradas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_gridEntrMercBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblentradaMercadoriaBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_locaisBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consultaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbllocaisBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PORTARIADataSet pORTARIADataSet;
        private System.Windows.Forms.BindingSource tblentradaMercadoriaBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_entrada_MercadoriaTableAdapter tbl_entrada_MercadoriaTableAdapter;
        private System.Windows.Forms.BindingSource tbltransportadoraBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_transportadoraTableAdapter tbl_transportadoraTableAdapter;
        private System.Windows.Forms.BindingSource tbllocaisBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_locaisTableAdapter tbl_locaisTableAdapter;
        private Carga.PORTARIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.ComboBox localcombo;
        private System.Windows.Forms.TextBox nftxt;
        private System.Windows.Forms.TextBox serietxt;
        private System.Windows.Forms.TextBox motoristatxt;
        private System.Windows.Forms.MaskedTextBox placamsktxt;
        private System.Windows.Forms.TextBox responsaveltxt;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox transcombo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource tbllocaisBindingSource1;
        private System.Windows.Forms.BindingSource tbltransportadoraBindingSource1;
        private System.Windows.Forms.TextBox obstxt;
        private System.Windows.Forms.BindingSource tbl_gridEntrMercBindingSource;
        private System.Windows.Forms.BindingSource tblentradaMercadoriaBindingSource1;
        private Carga.PORTARIADataSetTableAdapters.tbl_gridEntrMercTableAdapter tbl_gridEntrMercTableAdapter;
        private System.Windows.Forms.DataGridView GridEntradas;
        private ConsultaDataSet consultaDataSet;
        private System.Windows.Forms.BindingSource tbl_locaisBindingSource;
        private Carga.ConsultaDataSetTableAdapters.TableAdapterManager tableAdapterManager1;
        private System.Windows.Forms.BindingSource consultaDataSetBindingSource;
        private Carga.ConsultaDataSetTableAdapters.tbl_entrada_MercadoriaTableAdapter tbl_entrada_MercadoriaTableAdapter1;
        private System.Windows.Forms.BindingSource tbllocaisBindingSource2;
        private Carga.ConsultaDataSetTableAdapters.tbl_locaisTableAdapter tbl_locaisTableAdapter1;
    }
}
