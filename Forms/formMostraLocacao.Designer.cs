namespace LocacaoEquipamentos.Forms
{
    partial class FormMostraLocacao
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
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DataGridViewItensLocacao = new System.Windows.Forms.DataGridView();
            this.DataGridViewLocacao = new System.Windows.Forms.DataGridView();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItensLocacao)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocacao)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.BtnExcluir);
            this.tabPage1.Controls.Add(this.BtnAlterar);
            this.tabPage1.Controls.Add(this.BtnIncluir);
            this.tabPage1.Controls.Add(this.tabControl2);
            this.tabPage1.Controls.Add(this.DataGridViewLocacao);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(942, 449);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Location = new System.Drawing.Point(827, 97);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.Size = new System.Drawing.Size(107, 35);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Location = new System.Drawing.Point(827, 56);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.Size = new System.Drawing.Size(107, 35);
            this.BtnAlterar.TabIndex = 3;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Location = new System.Drawing.Point(827, 15);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.Size = new System.Drawing.Size(107, 35);
            this.BtnIncluir.TabIndex = 2;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage2);
            this.tabControl2.Location = new System.Drawing.Point(13, 234);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(808, 194);
            this.tabControl2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DataGridViewItensLocacao);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(800, 168);
            this.tabPage2.TabIndex = 0;
            this.tabPage2.Text = "Itens";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DataGridViewItensLocacao
            // 
            this.DataGridViewItensLocacao.AllowUserToAddRows = false;
            this.DataGridViewItensLocacao.AllowUserToDeleteRows = false;
            this.DataGridViewItensLocacao.AllowUserToResizeRows = false;
            this.DataGridViewItensLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewItensLocacao.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DataGridViewItensLocacao.Location = new System.Drawing.Point(6, 6);
            this.DataGridViewItensLocacao.MultiSelect = false;
            this.DataGridViewItensLocacao.Name = "DataGridViewItensLocacao";
            this.DataGridViewItensLocacao.ReadOnly = true;
            this.DataGridViewItensLocacao.Size = new System.Drawing.Size(788, 156);
            this.DataGridViewItensLocacao.TabIndex = 2;
            // 
            // DataGridViewLocacao
            // 
            this.DataGridViewLocacao.AllowUserToAddRows = false;
            this.DataGridViewLocacao.AllowUserToDeleteRows = false;
            this.DataGridViewLocacao.AllowUserToOrderColumns = true;
            this.DataGridViewLocacao.AllowUserToResizeRows = false;
            this.DataGridViewLocacao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridViewLocacao.Location = new System.Drawing.Point(13, 15);
            this.DataGridViewLocacao.Name = "DataGridViewLocacao";
            this.DataGridViewLocacao.ReadOnly = true;
            this.DataGridViewLocacao.Size = new System.Drawing.Size(808, 213);
            this.DataGridViewLocacao.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(950, 475);
            this.tabControl1.TabIndex = 0;
            // 
            // FormMostraLocacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(969, 499);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormMostraLocacao";
            this.Text = "FormMostraLocacao";
            this.tabPage1.ResumeLayout(false);
            this.tabControl2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewItensLocacao)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewLocacao)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView DataGridViewItensLocacao;
        private System.Windows.Forms.DataGridView DataGridViewLocacao;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.Button BtnAlterar;
    }
}