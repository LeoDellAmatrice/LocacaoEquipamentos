namespace LocacaoEquipamentos.Forms
{
    partial class FormAtualizaEquipamentos
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
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.TboxIdEquipamento = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
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
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.CbSituacao = new System.Windows.Forms.ComboBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.CbTipoEquipamento = new System.Windows.Forms.ComboBox();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TboxDescricao = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControlTiposEquipamentos.SuspendLayout();
            this.tabPageTipoFerramenta.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageTipoInformatica.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPageTipoMaquinaPesada.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(392, 421);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(81, 28);
            this.BtnCancelar.TabIndex = 4;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(305, 421);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(81, 28);
            this.BtnSalvar.TabIndex = 3;
            this.BtnSalvar.Text = "OK";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(461, 407);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox9);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox5);
            this.tabPage1.Controls.Add(this.tabControlTiposEquipamentos);
            this.tabPage1.Controls.Add(this.TboxIdEquipamento);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(453, 381);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // TboxIdEquipamento
            // 
            this.TboxIdEquipamento.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxIdEquipamento.Location = new System.Drawing.Point(39, 12);
            this.TboxIdEquipamento.MaxLength = 7;
            this.TboxIdEquipamento.Name = "TboxIdEquipamento";
            this.TboxIdEquipamento.ReadOnly = true;
            this.TboxIdEquipamento.Size = new System.Drawing.Size(57, 26);
            this.TboxIdEquipamento.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Id:";
            // 
            // tabControlTiposEquipamentos
            // 
            this.tabControlTiposEquipamentos.Controls.Add(this.tabPageTipoFerramenta);
            this.tabControlTiposEquipamentos.Controls.Add(this.tabPageTipoInformatica);
            this.tabControlTiposEquipamentos.Controls.Add(this.tabPageTipoMaquinaPesada);
            this.tabControlTiposEquipamentos.Location = new System.Drawing.Point(267, 172);
            this.tabControlTiposEquipamentos.Name = "tabControlTiposEquipamentos";
            this.tabControlTiposEquipamentos.SelectedIndex = 0;
            this.tabControlTiposEquipamentos.Size = new System.Drawing.Size(173, 201);
            this.tabControlTiposEquipamentos.TabIndex = 8;
            // 
            // tabPageTipoFerramenta
            // 
            this.tabPageTipoFerramenta.Controls.Add(this.groupBox1);
            this.tabPageTipoFerramenta.Location = new System.Drawing.Point(4, 22);
            this.tabPageTipoFerramenta.Name = "tabPageTipoFerramenta";
            this.tabPageTipoFerramenta.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTipoFerramenta.Size = new System.Drawing.Size(165, 175);
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
            this.tabPageTipoInformatica.Size = new System.Drawing.Size(165, 175);
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
            this.tabPageTipoMaquinaPesada.Size = new System.Drawing.Size(165, 175);
            this.tabPageTipoMaquinaPesada.TabIndex = 2;
            this.tabPageTipoMaquinaPesada.Text = "Máquina Pesada";
            this.tabPageTipoMaquinaPesada.UseVisualStyleBackColor = true;
            // 
            // checkedListBoxOperadorEspecializado
            // 
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
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.CbSituacao);
            this.groupBox5.Location = new System.Drawing.Point(267, 44);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(173, 58);
            this.groupBox5.TabIndex = 9;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Situação";
            // 
            // CbSituacao
            // 
            this.CbSituacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbSituacao.FormattingEnabled = true;
            this.CbSituacao.Location = new System.Drawing.Point(12, 22);
            this.CbSituacao.Name = "CbSituacao";
            this.CbSituacao.Size = new System.Drawing.Size(148, 21);
            this.CbSituacao.TabIndex = 2;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.CbTipoEquipamento);
            this.groupBox6.Location = new System.Drawing.Point(267, 108);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(173, 58);
            this.groupBox6.TabIndex = 4;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Tipo";
            // 
            // CbTipoEquipamento
            // 
            this.CbTipoEquipamento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoEquipamento.FormattingEnabled = true;
            this.CbTipoEquipamento.Location = new System.Drawing.Point(12, 22);
            this.CbTipoEquipamento.Name = "CbTipoEquipamento";
            this.CbTipoEquipamento.Size = new System.Drawing.Size(148, 21);
            this.CbTipoEquipamento.TabIndex = 2;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TboxDescricao);
            this.groupBox8.Location = new System.Drawing.Point(6, 44);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(255, 58);
            this.groupBox8.TabIndex = 12;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Descrição";
            // 
            // TboxDescricao
            // 
            this.TboxDescricao.Location = new System.Drawing.Point(6, 23);
            this.TboxDescricao.MaxLength = 11;
            this.TboxDescricao.Name = "TboxDescricao";
            this.TboxDescricao.Size = new System.Drawing.Size(243, 20);
            this.TboxDescricao.TabIndex = 6;
            this.TboxDescricao.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.textBox1);
            this.groupBox7.Location = new System.Drawing.Point(6, 108);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(255, 58);
            this.groupBox7.TabIndex = 13;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Valor Diária";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 23);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(243, 20);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.monthCalendar1);
            this.groupBox9.Location = new System.Drawing.Point(6, 172);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(255, 201);
            this.groupBox9.TabIndex = 14;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Data Aquisição";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 25);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // AtualizaEquipamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 459);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Name = "AtualizaEquipamentos";
            this.Text = "AtualizaEquipamentos";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
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
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button BtnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TboxIdEquipamento;
        private System.Windows.Forms.Label label1;
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.ComboBox CbTipoEquipamento;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ComboBox CbSituacao;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TboxDescricao;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox textBox1;
    }
}