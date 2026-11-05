namespace LocacaoEquipamentos.Forms
{
    partial class FormSelecionaCliente
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.DataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.BtnSelecionar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 397);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DataGridViewClientes);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(768, 371);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // DataGridViewClientes
            // 
            this.DataGridViewClientes.AllowUserToAddRows = false;
            this.DataGridViewClientes.AllowUserToDeleteRows = false;
            this.DataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewClientes.Location = new System.Drawing.Point(6, 6);
            this.DataGridViewClientes.Name = "DataGridViewClientes";
            this.DataGridViewClientes.ReadOnly = true;
            this.DataGridViewClientes.Size = new System.Drawing.Size(756, 359);
            this.DataGridViewClientes.TabIndex = 0;
            this.DataGridViewClientes.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.DataGridViewClientes_MouseDoubleClick);
            // 
            // BtnSelecionar
            // 
            this.BtnSelecionar.Location = new System.Drawing.Point(691, 415);
            this.BtnSelecionar.Name = "BtnSelecionar";
            this.BtnSelecionar.Size = new System.Drawing.Size(97, 31);
            this.BtnSelecionar.TabIndex = 1;
            this.BtnSelecionar.Text = "Selecionar";
            this.BtnSelecionar.UseVisualStyleBackColor = true;
            this.BtnSelecionar.Click += new System.EventHandler(this.BtnSelecionar_Click);
            // 
            // FormSelecionaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 458);
            this.Controls.Add(this.BtnSelecionar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormSelecionaCliente";
            this.Text = "FormSelecionaCliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.DataGridView DataGridViewClientes;
        private System.Windows.Forms.Button BtnSelecionar;
    }
}