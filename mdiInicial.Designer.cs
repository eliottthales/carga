namespace Carga
{
    partial class mdiInicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mdiInicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ndCarg = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeMercadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaDeMercadoriaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndVeic = new System.Windows.Forms.ToolStripMenuItem();
            this.frotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fiorinoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ambulânciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.particularToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndVisi = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndResi = new System.Windows.Forms.ToolStripMenuItem();
            this.saídaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndRela = new System.Windows.Forms.ToolStripMenuItem();
            this.entradaDeMercadoriaPorDataToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.residuosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ndCad = new System.Windows.Forms.ToolStripMenuItem();
            this.locaisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transportadoraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuáriosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.alterarSenhaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsslUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.pORTARIADataSet = new Carga.PORTARIADataSet();
            this.tbl_userProgBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_userProg = new Carga.PORTARIADataSetTableAdapters.tbl_userProg();
            this.tableAdapterManager = new Carga.PORTARIADataSetTableAdapters.TableAdapterManager();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userProgBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ndCarg,
            this.ndVeic,
            this.ndVisi,
            this.ndResi,
            this.ndRela,
            this.ndCad,
            this.alterarSenhaToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(836, 27);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ndCarg
            // 
            this.ndCarg.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeMercadoriaToolStripMenuItem,
            this.saídaDeMercadoriaToolStripMenuItem});
            this.ndCarg.Enabled = false;
            this.ndCarg.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndCarg.Image = ((System.Drawing.Image)(resources.GetObject("ndCarg.Image")));
            this.ndCarg.Name = "ndCarg";
            this.ndCarg.Size = new System.Drawing.Size(75, 23);
            this.ndCarg.Text = "Carga";
            // 
            // entradaDeMercadoriaToolStripMenuItem
            // 
            this.entradaDeMercadoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaDeMercadoriaToolStripMenuItem.Image")));
            this.entradaDeMercadoriaToolStripMenuItem.Name = "entradaDeMercadoriaToolStripMenuItem";
            this.entradaDeMercadoriaToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.entradaDeMercadoriaToolStripMenuItem.Text = "Entrada de Mercadoria";
            this.entradaDeMercadoriaToolStripMenuItem.Click += new System.EventHandler(this.entradaDeMercadoriaToolStripMenuItem_Click);
            // 
            // saídaDeMercadoriaToolStripMenuItem
            // 
            this.saídaDeMercadoriaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saídaDeMercadoriaToolStripMenuItem.Image")));
            this.saídaDeMercadoriaToolStripMenuItem.Name = "saídaDeMercadoriaToolStripMenuItem";
            this.saídaDeMercadoriaToolStripMenuItem.Size = new System.Drawing.Size(226, 24);
            this.saídaDeMercadoriaToolStripMenuItem.Text = "Saída de Mercadoria";
            this.saídaDeMercadoriaToolStripMenuItem.Click += new System.EventHandler(this.saídaDeMercadoriaToolStripMenuItem_Click);
            // 
            // ndVeic
            // 
            this.ndVeic.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.frotaToolStripMenuItem,
            this.particularToolStripMenuItem});
            this.ndVeic.Enabled = false;
            this.ndVeic.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndVeic.Image = ((System.Drawing.Image)(resources.GetObject("ndVeic.Image")));
            this.ndVeic.Name = "ndVeic";
            this.ndVeic.Size = new System.Drawing.Size(91, 23);
            this.ndVeic.Text = "Veículos";
            // 
            // frotaToolStripMenuItem
            // 
            this.frotaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fiorinoToolStripMenuItem,
            this.ambulânciaToolStripMenuItem});
            this.frotaToolStripMenuItem.Name = "frotaToolStripMenuItem";
            this.frotaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.frotaToolStripMenuItem.Text = "Frota";
            // 
            // fiorinoToolStripMenuItem
            // 
            this.fiorinoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("fiorinoToolStripMenuItem.Image")));
            this.fiorinoToolStripMenuItem.Name = "fiorinoToolStripMenuItem";
            this.fiorinoToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.fiorinoToolStripMenuItem.Text = "Fiorino";
            this.fiorinoToolStripMenuItem.Click += new System.EventHandler(this.fiorinoToolStripMenuItem_Click);
            // 
            // ambulânciaToolStripMenuItem
            // 
            this.ambulânciaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ambulânciaToolStripMenuItem.Image")));
            this.ambulânciaToolStripMenuItem.Name = "ambulânciaToolStripMenuItem";
            this.ambulânciaToolStripMenuItem.Size = new System.Drawing.Size(154, 24);
            this.ambulânciaToolStripMenuItem.Text = "Ambulância";
            // 
            // particularToolStripMenuItem
            // 
            this.particularToolStripMenuItem.Name = "particularToolStripMenuItem";
            this.particularToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.particularToolStripMenuItem.Text = "Particular";
            this.particularToolStripMenuItem.Click += new System.EventHandler(this.particularToolStripMenuItem_Click);
            // 
            // ndVisi
            // 
            this.ndVisi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroToolStripMenuItem});
            this.ndVisi.Enabled = false;
            this.ndVisi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndVisi.Image = ((System.Drawing.Image)(resources.GetObject("ndVisi.Image")));
            this.ndVisi.Name = "ndVisi";
            this.ndVisi.Size = new System.Drawing.Size(102, 23);
            this.ndVisi.Text = "Visitantes";
            // 
            // cadastroToolStripMenuItem
            // 
            this.cadastroToolStripMenuItem.Name = "cadastroToolStripMenuItem";
            this.cadastroToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.cadastroToolStripMenuItem.Text = "Cadastro";
            this.cadastroToolStripMenuItem.Click += new System.EventHandler(this.cadastroToolStripMenuItem_Click);
            // 
            // ndResi
            // 
            this.ndResi.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saídaToolStripMenuItem});
            this.ndResi.Enabled = false;
            this.ndResi.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndResi.Image = ((System.Drawing.Image)(resources.GetObject("ndResi.Image")));
            this.ndResi.Name = "ndResi";
            this.ndResi.Size = new System.Drawing.Size(96, 23);
            this.ndResi.Text = "Resíduos";
            // 
            // saídaToolStripMenuItem
            // 
            this.saídaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("saídaToolStripMenuItem.Image")));
            this.saídaToolStripMenuItem.Name = "saídaToolStripMenuItem";
            this.saídaToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.saídaToolStripMenuItem.Text = "Saída";
            this.saídaToolStripMenuItem.Click += new System.EventHandler(this.saídaToolStripMenuItem_Click);
            // 
            // ndRela
            // 
            this.ndRela.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.entradaDeMercadoriaPorDataToolStripMenuItem,
            this.residuosToolStripMenuItem});
            this.ndRela.Enabled = false;
            this.ndRela.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndRela.Image = ((System.Drawing.Image)(resources.GetObject("ndRela.Image")));
            this.ndRela.Name = "ndRela";
            this.ndRela.Size = new System.Drawing.Size(103, 23);
            this.ndRela.Text = "Relatórios";
            // 
            // entradaDeMercadoriaPorDataToolStripMenuItem
            // 
            this.entradaDeMercadoriaPorDataToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("entradaDeMercadoriaPorDataToolStripMenuItem.Image")));
            this.entradaDeMercadoriaPorDataToolStripMenuItem.Name = "entradaDeMercadoriaPorDataToolStripMenuItem";
            this.entradaDeMercadoriaPorDataToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.entradaDeMercadoriaPorDataToolStripMenuItem.Text = "Carga";
            this.entradaDeMercadoriaPorDataToolStripMenuItem.Click += new System.EventHandler(this.entradaDeMercadoriaPorDataToolStripMenuItem_Click);
            // 
            // residuosToolStripMenuItem
            // 
            this.residuosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("residuosToolStripMenuItem.Image")));
            this.residuosToolStripMenuItem.Name = "residuosToolStripMenuItem";
            this.residuosToolStripMenuItem.Size = new System.Drawing.Size(152, 24);
            this.residuosToolStripMenuItem.Text = "Residuos";
            this.residuosToolStripMenuItem.Click += new System.EventHandler(this.residuosToolStripMenuItem_Click);
            // 
            // ndCad
            // 
            this.ndCad.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.locaisToolStripMenuItem,
            this.transportadoraToolStripMenuItem,
            this.usuáriosToolStripMenuItem});
            this.ndCad.Enabled = false;
            this.ndCad.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ndCad.Image = ((System.Drawing.Image)(resources.GetObject("ndCad.Image")));
            this.ndCad.Name = "ndCad";
            this.ndCad.Size = new System.Drawing.Size(102, 23);
            this.ndCad.Text = "Cadastros";
            // 
            // locaisToolStripMenuItem
            // 
            this.locaisToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("locaisToolStripMenuItem.Image")));
            this.locaisToolStripMenuItem.Name = "locaisToolStripMenuItem";
            this.locaisToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.locaisToolStripMenuItem.Text = "Locais";
            this.locaisToolStripMenuItem.Click += new System.EventHandler(this.locaisToolStripMenuItem_Click);
            // 
            // transportadoraToolStripMenuItem
            // 
            this.transportadoraToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("transportadoraToolStripMenuItem.Image")));
            this.transportadoraToolStripMenuItem.Name = "transportadoraToolStripMenuItem";
            this.transportadoraToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.transportadoraToolStripMenuItem.Text = "Transportadora";
            this.transportadoraToolStripMenuItem.Click += new System.EventHandler(this.transportadoraToolStripMenuItem_Click);
            // 
            // usuáriosToolStripMenuItem
            // 
            this.usuáriosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("usuáriosToolStripMenuItem.Image")));
            this.usuáriosToolStripMenuItem.Name = "usuáriosToolStripMenuItem";
            this.usuáriosToolStripMenuItem.Size = new System.Drawing.Size(176, 24);
            this.usuáriosToolStripMenuItem.Text = "Usuários";
            this.usuáriosToolStripMenuItem.Click += new System.EventHandler(this.usuáriosToolStripMenuItem_Click);
            // 
            // alterarSenhaToolStripMenuItem
            // 
            this.alterarSenhaToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alterarSenhaToolStripMenuItem.Name = "alterarSenhaToolStripMenuItem";
            this.alterarSenhaToolStripMenuItem.Size = new System.Drawing.Size(108, 23);
            this.alterarSenhaToolStripMenuItem.Text = "Alterar Senha";
            this.alterarSenhaToolStripMenuItem.Click += new System.EventHandler(this.alterarSenhaToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(45, 23);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 469);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 13, 0);
            this.statusStrip1.Size = new System.Drawing.Size(836, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsslUsuario
            // 
            this.tsslUsuario.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tsslUsuario.Name = "tsslUsuario";
            this.tsslUsuario.Size = new System.Drawing.Size(53, 17);
            this.tsslUsuario.Text = "Usuário:";
            // 
            // pORTARIADataSet
            // 
            this.pORTARIADataSet.DataSetName = "PORTARIADataSet";
            this.pORTARIADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tbl_userProgBindingSource
            // 
            this.tbl_userProgBindingSource.DataMember = "tbl_userProg";
            this.tbl_userProgBindingSource.DataSource = this.pORTARIADataSet;
            // 
            // tbl_userProg
            // 
            this.tbl_userProg.ClearBeforeFill = true;
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
            // mdiInicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 491);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 2, 4, 2);
            this.MaximizeBox = false;
            this.Name = "mdiInicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Autoneum Brasil Têxteis Acústicos Ltda - Segurança";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.mdiInicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pORTARIADataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_userProgBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ndCarg;
        private System.Windows.Forms.ToolStripMenuItem entradaDeMercadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saídaDeMercadoriaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndVeic;
        private System.Windows.Forms.ToolStripMenuItem frotaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem particularToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndVisi;
        private System.Windows.Forms.ToolStripMenuItem cadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndResi;
        private System.Windows.Forms.ToolStripMenuItem saídaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alterarSenhaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndCad;
        private System.Windows.Forms.ToolStripMenuItem locaisToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transportadoraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuáriosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fiorinoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ambulânciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ndRela;
        private System.Windows.Forms.ToolStripMenuItem entradaDeMercadoriaPorDataToolStripMenuItem;
        private PORTARIADataSet pORTARIADataSet;
        private System.Windows.Forms.BindingSource tbl_userProgBindingSource;
        private Carga.PORTARIADataSetTableAdapters.tbl_userProg tbl_userProg;
        private Carga.PORTARIADataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsslUsuario;
        private System.Windows.Forms.ToolStripMenuItem residuosToolStripMenuItem;
    }
}
