namespace LocacaoEquipamentos
{
    partial class FormMostraEquipamentos
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.BtnIncluir = new System.Windows.Forms.Button();
            this.BtnAlterar = new System.Windows.Forms.Button();
            this.BtnExcluir = new System.Windows.Forms.Button();
            this.tabControlTiposEquipamentos = new System.Windows.Forms.TabControl();
            this.tabPageTipoFerramenta = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TboxVoltagem = new System.Windows.Forms.TextBox();
            this.tabPageTipoInformatica = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TboxFabricante = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TboxNumeroSerie = new System.Windows.Forms.TextBox();
            this.tabPageTipoMaquinaPesada = new System.Windows.Forms.TabPage();
            this.checkedListBoxOperadorEspecializado = new System.Windows.Forms.CheckedListBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TboxPeso = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControlTiposEquipamentos.SuspendLayout();
            this.tabPageTipoFerramenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageTipoInformatica.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageTipoMaquinaPesada.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(776, 347);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // BtnIncluir
            // 
            this.BtnIncluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnIncluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnIncluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnIncluir.Location = new System.Drawing.Point(455, 365);
            this.BtnIncluir.Name = "BtnIncluir";
            this.BtnIncluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnIncluir.Size = new System.Drawing.Size(107, 35);
            this.BtnIncluir.TabIndex = 6;
            this.BtnIncluir.Text = "Incluir";
            this.BtnIncluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnIncluir.UseVisualStyleBackColor = true;
            this.BtnIncluir.Click += new System.EventHandler(this.BtnIncluir_Click);
            // 
            // BtnAlterar
            // 
            this.BtnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAlterar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAlterar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnAlterar.Location = new System.Drawing.Point(568, 365);
            this.BtnAlterar.Name = "BtnAlterar";
            this.BtnAlterar.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnAlterar.Size = new System.Drawing.Size(107, 35);
            this.BtnAlterar.TabIndex = 5;
            this.BtnAlterar.Text = "Alterar";
            this.BtnAlterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnAlterar.UseVisualStyleBackColor = true;
            this.BtnAlterar.Click += new System.EventHandler(this.BtnAlterar_Click);
            // 
            // BtnExcluir
            // 
            this.BtnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnExcluir.Location = new System.Drawing.Point(681, 365);
            this.BtnExcluir.Name = "BtnExcluir";
            this.BtnExcluir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BtnExcluir.Size = new System.Drawing.Size(107, 35);
            this.BtnExcluir.TabIndex = 4;
            this.BtnExcluir.Text = "Excluir";
            this.BtnExcluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.BtnExcluir.UseVisualStyleBackColor = true;
            this.BtnExcluir.Click += new System.EventHandler(this.BtnExcluir_Click);
            // 
            // tabControlTiposEquipamentos
            // 
            this.tabControlTiposEquipamentos.Controls.Add(this.tabPageTipoFerramenta);
            this.tabControlTiposEquipamentos.Controls.Add(this.tabPageTipoInformatica);
            this.tabControlTiposEquipamentos.Controls.Add(this.tabPageTipoMaquinaPesada);
            this.tabControlTiposEquipamentos.Location = new System.Drawing.Point(794, 12);
            this.tabControlTiposEquipamentos.Name = "tabControlTiposEquipamentos";
            this.tabControlTiposEquipamentos.SelectedIndex = 0;
            this.tabControlTiposEquipamentos.Size = new System.Drawing.Size(173, 159);
            this.tabControlTiposEquipamentos.TabIndex = 7;
            // 
            // tabPageTipoFerramenta
            // 
            this.tabPageTipoFerramenta.Controls.Add(this.groupBox1);
            this.tabPageTipoFerramenta.Location = new System.Drawing.Point(4, 22);
            this.tabPageTipoFerramenta.Name = "tabPageTipoFerramenta";
            this.tabPageTipoFerramenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTipoFerramenta.Size = new System.Drawing.Size(165, 133);
            this.tabPageTipoFerramenta.TabIndex = 0;
            this.tabPageTipoFerramenta.Text = "Ferramenta";
            this.tabPageTipoFerramenta.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TboxVoltagem);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(150, 56);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Voltagem";
            // 
            // TboxVoltagem
            // 
            this.TboxVoltagem.Location = new System.Drawing.Point(6, 19);
            this.TboxVoltagem.Name = "TboxVoltagem";
            this.TboxVoltagem.ReadOnly = true;
            this.TboxVoltagem.Size = new System.Drawing.Size(138, 20);
            this.TboxVoltagem.TabIndex = 0;
            this.TboxVoltagem.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageTipoInformatica
            // 
            this.tabPageTipoInformatica.Controls.Add(this.groupBox3);
            this.tabPageTipoInformatica.Controls.Add(this.groupBox2);
            this.tabPageTipoInformatica.Location = new System.Drawing.Point(4, 22);
            this.tabPageTipoInformatica.Name = "tabPageTipoInformatica";
            this.tabPageTipoInformatica.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTipoInformatica.Size = new System.Drawing.Size(165, 133);
            this.tabPageTipoInformatica.TabIndex = 1;
            this.tabPageTipoInformatica.Text = "Informática";
            this.tabPageTipoInformatica.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TboxFabricante);
            this.groupBox3.Location = new System.Drawing.Point(6, 68);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(150, 56);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Fabricante";
            // 
            // TboxFabricante
            // 
            this.TboxFabricante.Location = new System.Drawing.Point(6, 19);
            this.TboxFabricante.Name = "TboxFabricante";
            this.TboxFabricante.ReadOnly = true;
            this.TboxFabricante.Size = new System.Drawing.Size(138, 20);
            this.TboxFabricante.TabIndex = 0;
            this.TboxFabricante.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TboxNumeroSerie);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(150, 56);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Número Série";
            // 
            // TboxNumeroSerie
            // 
            this.TboxNumeroSerie.Location = new System.Drawing.Point(6, 19);
            this.TboxNumeroSerie.Name = "TboxNumeroSerie";
            this.TboxNumeroSerie.ReadOnly = true;
            this.TboxNumeroSerie.Size = new System.Drawing.Size(138, 20);
            this.TboxNumeroSerie.TabIndex = 0;
            this.TboxNumeroSerie.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tabPageTipoMaquinaPesada
            // 
            this.tabPageTipoMaquinaPesada.Controls.Add(this.checkedListBoxOperadorEspecializado);
            this.tabPageTipoMaquinaPesada.Controls.Add(this.groupBox4);
            this.tabPageTipoMaquinaPesada.Location = new System.Drawing.Point(4, 22);
            this.tabPageTipoMaquinaPesada.Name = "tabPageTipoMaquinaPesada";
            this.tabPageTipoMaquinaPesada.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTipoMaquinaPesada.Size = new System.Drawing.Size(165, 133);
            this.tabPageTipoMaquinaPesada.TabIndex = 2;
            this.tabPageTipoMaquinaPesada.Text = "Máquina Pesada";
            this.tabPageTipoMaquinaPesada.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxOperadorEspecializado
            // 
            this.checkedListBoxOperadorEspecializado.Enabled = false;
            this.checkedListBoxOperadorEspecializado.FormattingEnabled = true;
            this.checkedListBoxOperadorEspecializado.Items.AddRange(new object[] {
            "Operador Especializado\t"});
            this.checkedListBoxOperadorEspecializado.Location = new System.Drawing.Point(6, 68);
            this.checkedListBoxOperadorEspecializado.Name = "checkedListBoxOperadorEspecializado";
            this.checkedListBoxOperadorEspecializado.Size = new System.Drawing.Size(150, 19);
            this.checkedListBoxOperadorEspecializado.TabIndex = 3;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TboxPeso);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(150, 56);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Peso";
            // 
            // TboxPeso
            // 
            this.TboxPeso.Location = new System.Drawing.Point(6, 19);
            this.TboxPeso.Name = "TboxPeso";
            this.TboxPeso.ReadOnly = true;
            this.TboxPeso.Size = new System.Drawing.Size(138, 20);
            this.TboxPeso.TabIndex = 0;
            this.TboxPeso.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FormMostraEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1177, 410);
            this.Controls.Add(this.tabControlTiposEquipamentos);
            this.Controls.Add(this.BtnIncluir);
            this.Controls.Add(this.BtnAlterar);
            this.Controls.Add(this.BtnExcluir);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormMostraEquipamentos";
            this.Text = "FormMostraEquipamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControlTiposEquipamentos.ResumeLayout(false);
            this.tabPageTipoFerramenta.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageTipoInformatica.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPageTipoMaquinaPesada.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button BtnIncluir;
        private System.Windows.Forms.Button BtnAlterar;
        private System.Windows.Forms.Button BtnExcluir;
        private System.Windows.Forms.TabControl tabControlTiposEquipamentos;
        private System.Windows.Forms.TabPage tabPageTipoFerramenta;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TboxVoltagem;
        private System.Windows.Forms.TabPage tabPageTipoInformatica;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TboxFabricante;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox TboxNumeroSerie;
        private System.Windows.Forms.TabPage tabPageTipoMaquinaPesada;
        private System.Windows.Forms.CheckedListBox checkedListBoxOperadorEspecializado;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TboxPeso;
    }
}