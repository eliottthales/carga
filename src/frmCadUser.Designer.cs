namespace Carga
{
    partial class frmCadUser
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
            System.Windows.Forms.Label situacaoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label usuarioLabel;
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Carga");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Veículos");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Visitantes");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Residuos");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Relatórios");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Cadastro");
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadUser));
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tevProg = new System.Windows.Forms.TreeView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.alterarsenhacheck = new System.Windows.Forms.CheckBox();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.situacaoCheckBox = new System.Windows.Forms.CheckBox();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.GridUser = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.situacaoDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.tbl_userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.pORTARIADataSet = new Carga.PORTARIADataSet();
            this.tbl_userTableAdapter = new Carga.PORTARIADataSetTableAdapters.tbl_userTableAdapter();
            this.tableAdapterManager = new Carga.PORTARIADataSetTableAdapters.TableAdapterManager();
            this.tbl_userProgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblusertbluserProgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_userProg = new Carga.PORTARIADataSetTableAdapters.tbl_userProg();
            situacaoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            usuarioLabel = new System.Windows.Forms.Label();
            this.tabPage2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).BeginInit();
            this.tabControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userProgBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusertbluserProgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // situacaoLabel
            // 
            situacaoLabel.AutoSize = true;
            situacaoLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            situacaoLabel.Location = new System.Drawing.Point(6, 101);
            situacaoLabel.Name = "situacaoLabel";
            situacaoLabel.Size = new System.Drawing.Size(57, 14);
            situacaoLabel.TabIndex = 19;
            situacaoLabel.Text = "Situação:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(6, 60);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(43, 14);
            nomeLabel.TabIndex = 13;
            nomeLabel.Text = "Nome:";
            // 
            // usuarioLabel
            // 
            usuarioLabel.AutoSize = true;
            usuarioLabel.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            usuarioLabel.Location = new System.Drawing.Point(8, 18);
            usuarioLabel.Name = "usuarioLabel";
            usuarioLabel.Size = new System.Drawing.Size(50, 14);
            usuarioLabel.TabIndex = 15;
            usuarioLabel.Text = "Usuário:";
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Controls.Add(this.btnSalvar);
            this.tabPage2.Controls.Add(this.btnCancelar);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(382, 340);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Cadastro";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tevProg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 163);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(372, 144);
            this.groupBox1.TabIndex = 20;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Acessos";
            // 
            // tevProg
            // 
            this.tevProg.CheckBoxes = true;
            this.tevProg.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tevProg.Location = new System.Drawing.Point(2, 19);
            this.tevProg.Name = "tevProg";
            treeNode1.Name = "ndCarg";
            treeNode1.Text = "Carga";
            treeNode2.Name = "ndVeic";
            treeNode2.Text = "Veículos";
            treeNode3.Name = "ndVisi";
            treeNode3.Text = "Visitantes";
            treeNode4.Name = "ndResi";
            treeNode4.Text = "Residuos";
            treeNode5.Name = "ndRela";
            treeNode5.Text = "Relatórios";
            treeNode6.Name = "ndCad";
            treeNode6.Text = "Cadastro";
            this.tevProg.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2,
            treeNode3,
            treeNode4,
            treeNode5,
            treeNode6});
            this.tevProg.Size = new System.Drawing.Size(362, 123);
            this.tevProg.TabIndex = 6;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.Location = new System.Drawing.Point(211, 313);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(292, 313);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.alterarsenhacheck);
            this.groupBox2.Controls.Add(this.txtUsuario);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(situacaoLabel);
            this.groupBox2.Controls.Add(this.situacaoCheckBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(usuarioLabel);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(3, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(374, 151);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados";
            // 
            // alterarsenhacheck
            // 
            this.alterarsenhacheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarsenhacheck.Location = new System.Drawing.Point(103, 118);
            this.alterarsenhacheck.Name = "alterarsenhacheck";
            this.alterarsenhacheck.Size = new System.Drawing.Size(119, 24);
            this.alterarsenhacheck.TabIndex = 5;
            this.alterarsenhacheck.Text = "Alterar Senha";
            this.alterarsenhacheck.UseVisualStyleBackColor = true;
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(6, 36);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(113, 21);
            this.txtUsuario.TabIndex = 2;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.Location = new System.Drawing.Point(9, 77);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(227, 21);
            this.nomeTextBox.TabIndex = 3;
            // 
            // situacaoCheckBox
            // 
            this.situacaoCheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.situacaoCheckBox.Location = new System.Drawing.Point(9, 118);
            this.situacaoCheckBox.Name = "situacaoCheckBox";
            this.situacaoCheckBox.Size = new System.Drawing.Size(63, 24);
            this.situacaoCheckBox.TabIndex = 4;
            this.situacaoCheckBox.Text = "Ativo";
            this.situacaoCheckBox.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnSair);
            this.tabPage1.Controls.Add(this.btnExcluir);
            this.tabPage1.Controls.Add(this.btnEditar);
            this.tabPage1.Controls.Add(this.btnInserir);
            this.tabPage1.Controls.Add(this.GridUser);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(382, 340);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Consulta";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(305, 311);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 23);
            this.btnSair.TabIndex = 24;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.Location = new System.Drawing.Point(223, 311);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 23;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(142, 311);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 22;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnInserir
            // 
            this.btnInserir.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInserir.Location = new System.Drawing.Point(61, 311);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 21;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // GridUser
            // 
            this.GridUser.AllowUserToAddRows = false;
            this.GridUser.AllowUserToDeleteRows = false;
            this.GridUser.AutoGenerateColumns = false;
            this.GridUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.GridUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nomeDataGridViewTextBoxColumn,
            this.usuarioDataGridViewTextBoxColumn,
            this.situacaoDataGridViewCheckBoxColumn});
            this.GridUser.DataSource = this.tbl_userBindingSource;
            this.GridUser.Location = new System.Drawing.Point(3, 3);
            this.GridUser.Name = "GridUser";
            this.GridUser.ReadOnly = true;
            this.GridUser.Size = new System.Drawing.Size(377, 302);
            this.GridUser.TabIndex = 11;
            this.GridUser.DoubleClick += new System.EventHandler(this.GridUser_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.AccessibleName = "";
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-5, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(390, 366);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.ReadOnly = true;
            this.nomeDataGridViewTextBoxColumn.Width = 60;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuário";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.usuarioDataGridViewTextBoxColumn.Width = 68;
            // 
            // situacaoDataGridViewCheckBoxColumn
            // 
            this.situacaoDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.situacaoDataGridViewCheckBoxColumn.DataPropertyName = "situacao";
            this.situacaoDataGridViewCheckBoxColumn.HeaderText = "Situação";
            this.situacaoDataGridViewCheckBoxColumn.Name = "situacaoDataGridViewCheckBoxColumn";
            this.situacaoDataGridViewCheckBoxColumn.ReadOnly = true;
            this.situacaoDataGridViewCheckBoxColumn.Width = 55;
            // 
            // tbl_userBindingSource
            // 
            this.tbl_userBindingSource.DataMember = "tbl_user";
            this.tbl_userBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // pORTARIADataSet
            // 
            this.pORTARIADataSet.DataSetName = "PORTARIADataSet";
            this.pORTARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_userTableAdapter
            // 
            this.tbl_userTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            
            this.tableAdapterManager.tbl_entrada_MercadoriaTableAdapter = null;
            
            this.tableAdapterManager.tbl_locaisTableAdapter = null;
            
            this.tableAdapterManager.tbl_residuoTableAdapter = null;
            this.tableAdapterManager.tbl_saida_MercadoriaTableAdapter = null;
            this.tableAdapterManager.tbl_transportadoraTableAdapter = null;
            this.tableAdapterManager.tbl_userTableAdapter = this.tbl_userTableAdapter;
            
            this.tableAdapterManager.UpdateOrder = Carga.PORTARIADataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // tbl_userProgBindingSource
            // 
            this.tbl_userProgBindingSource.DataMember = "tbl_userProg";
            this.tbl_userProgBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // tblusertbluserProgBindingSource
            // 
            this.tblusertbluserProgBindingSource.DataMember = "tbl_userProg";
            this.tblusertbluserProgBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // tbl_userProg
            // 
            this.tbl_userProg.ClearBeforeFill = true;
            // 
            // frmCadUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 366);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCadUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro De Usuários";
            this.Load += new System.EventHandler(this.frmCadUser_Load);
            this.tabPage2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.GridUser)).EndInit();
            this.tabControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userProgBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblusertbluserProgBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private PORTARIADataSet pORTARIADataSet;
        private System.Windows.Forms.BindingSource tbl_userBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_userTableAdapter tbl_userTableAdapter;
        private Carga.PORTARIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView GridUser;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.CheckBox situacaoCheckBox;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.BindingSource tbl_userProgBindingSource;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TreeView tevProg;
        private System.Windows.Forms.CheckBox alterarsenhacheck;
        private System.Windows.Forms.BindingSource tblusertbluserProgBindingSource;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn situacaoDataGridViewCheckBoxColumn;
        private Carga.PORTARIADataSetTableAdapters.tbl_userProg tbl_userProg;
    }
}
