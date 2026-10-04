namespace LocacaoEquipamentos
{
    partial class FormMostraClientes
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
            this.dataGridViewClientes = new System.Windows.Forms.DataGridView();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewClientes
            // 
            this.dataGridViewClientes.AllowUserToAddRows = false;
            this.dataGridViewClientes.AllowUserToDeleteRows = false;
            this.dataGridViewClientes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClientes.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewClientes.Name = "dataGridViewClientes";
            this.dataGridViewClientes.ReadOnly = true;
            this.dataGridViewClientes.Size = new System.Drawing.Size(847, 353);
            this.dataGridViewClientes.TabIndex = 0;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(752, 371);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnExcluir.Size = new System.Drawing.Size(107, 35);
            this.BtnExcluir.TabIndex = 1;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterar.Location = new System.Drawing.Point(639, 371);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlterar.Size = new System.Drawing.Size(107, 35);
            this.BtnAlterar.TabIndex = 2;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncluir.Location = new System.Drawing.Point(526, 371);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnIncluir.Size = new System.Drawing.Size(107, 35);
            this.BtnIncluir.TabIndex = 3;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // FormMostraClientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(871, 458);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.dataGridViewClientes);
            this.Name = "FormMostraClientes";
            this.Text = "FormMostraClientes";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewClientes;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnIncluir;
    }
}