namespace LocacaoEquipamentos
{
    partial class FormAtualizaCliente
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
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.TboxTelefone = new System.Windows.Forms.TextBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.TboxEmail = new System.Windows.Forms.TextBox();
            this.TabControlTipoPessoa = new System.Windows.Forms.TabControl();
            this.TabPagePessoaJuridica = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.TboxNomeFantasia = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.TboxRazaoSocial = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.TboxCNPJ = new System.Windows.Forms.TextBox();
            this.TabPagePessoaFisica = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.TboxNome = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TboxCPF = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.CbTipoPessoa = new System.Windows.Forms.ComboBox();
            this.TboxIdCliente = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.BtnCancelar = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.TabControlTipoPessoa.SuspendLayout();
            this.TabPagePessoaJuridica.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.TabPagePessoaFisica.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(542, 370);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox8);
            this.tabPage1.Controls.Add(this.groupBox7);
            this.tabPage1.Controls.Add(this.TabControlTipoPessoa);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.TboxIdCliente);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(534, 344);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Principal";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.TboxTelefone);
            this.groupBox8.Location = new System.Drawing.Point(328, 44);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(195, 58);
            this.groupBox8.TabIndex = 11;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Telefone";
            // 
            // TboxTelefone
            // 
            this.TboxTelefone.Location = new System.Drawing.Point(6, 23);
            this.TboxTelefone.MaxLength = 11;
            this.TboxTelefone.Name = "TboxTelefone";
            this.TboxTelefone.Size = new System.Drawing.Size(183, 20);
            this.TboxTelefone.TabIndex = 6;
            this.TboxTelefone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.TboxEmail);
            this.groupBox7.Location = new System.Drawing.Point(10, 275);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(513, 58);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Email";
            // 
            // TboxEmail
            // 
            this.TboxEmail.Location = new System.Drawing.Point(6, 23);
            this.TboxEmail.MaxLength = 255;
            this.TboxEmail.Name = "TboxEmail";
            this.TboxEmail.Size = new System.Drawing.Size(501, 20);
            this.TboxEmail.TabIndex = 6;
            // 
            // TabControlTipoPessoa
            // 
            this.TabControlTipoPessoa.Controls.Add(this.TabPagePessoaJuridica);
            this.TabControlTipoPessoa.Controls.Add(this.TabPagePessoaFisica);
            this.TabControlTipoPessoa.Location = new System.Drawing.Point(10, 108);
            this.TabControlTipoPessoa.Name = "TabControlTipoPessoa";
            this.TabControlTipoPessoa.SelectedIndex = 0;
            this.TabControlTipoPessoa.Size = new System.Drawing.Size(517, 161);
            this.TabControlTipoPessoa.TabIndex = 9;
            // 
            // TabPagePessoaJuridica
            // 
            this.TabPagePessoaJuridica.Controls.Add(this.groupBox6);
            this.TabPagePessoaJuridica.Controls.Add(this.groupBox2);
            this.TabPagePessoaJuridica.Controls.Add(this.groupBox4);
            this.TabPagePessoaJuridica.Location = new System.Drawing.Point(4, 22);
            this.TabPagePessoaJuridica.Name = "TabPagePessoaJuridica";
            this.TabPagePessoaJuridica.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePessoaJuridica.Size = new System.Drawing.Size(509, 135);
            this.TabPagePessoaJuridica.TabIndex = 0;
            this.TabPagePessoaJuridica.Text = "Jurídica";
            this.TabPagePessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.TboxNomeFantasia);
            this.groupBox6.Location = new System.Drawing.Point(257, 70);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(243, 58);
            this.groupBox6.TabIndex = 9;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Nome Fantasia";
            // 
            // TboxNomeFantasia
            // 
            this.TboxNomeFantasia.Location = new System.Drawing.Point(6, 23);
            this.TboxNomeFantasia.MaxLength = 100;
            this.TboxNomeFantasia.Name = "TboxNomeFantasia";
            this.TboxNomeFantasia.Size = new System.Drawing.Size(231, 20);
            this.TboxNomeFantasia.TabIndex = 6;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TboxRazaoSocial);
            this.groupBox2.Location = new System.Drawing.Point(8, 70);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(243, 58);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Razão Social";
            // 
            // TboxRazaoSocial
            // 
            this.TboxRazaoSocial.Location = new System.Drawing.Point(6, 23);
            this.TboxRazaoSocial.MaxLength = 100;
            this.TboxRazaoSocial.Name = "TboxRazaoSocial";
            this.TboxRazaoSocial.Size = new System.Drawing.Size(231, 20);
            this.TboxRazaoSocial.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.TboxCNPJ);
            this.groupBox4.Location = new System.Drawing.Point(8, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(243, 58);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "CNPJ";
            // 
            // TboxCNPJ
            // 
            this.TboxCNPJ.Location = new System.Drawing.Point(6, 23);
            this.TboxCNPJ.MaxLength = 14;
            this.TboxCNPJ.Name = "TboxCNPJ";
            this.TboxCNPJ.Size = new System.Drawing.Size(231, 20);
            this.TboxCNPJ.TabIndex = 6;
            this.TboxCNPJ.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TabPagePessoaFisica
            // 
            this.TabPagePessoaFisica.Controls.Add(this.groupBox5);
            this.TabPagePessoaFisica.Controls.Add(this.groupBox3);
            this.TabPagePessoaFisica.Location = new System.Drawing.Point(4, 22);
            this.TabPagePessoaFisica.Name = "TabPagePessoaFisica";
            this.TabPagePessoaFisica.Padding = new System.Windows.Forms.Padding(3);
            this.TabPagePessoaFisica.Size = new System.Drawing.Size(509, 135);
            this.TabPagePessoaFisica.TabIndex = 1;
            this.TabPagePessoaFisica.Text = "Física";
            this.TabPagePessoaFisica.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.TboxNome);
            this.groupBox5.Location = new System.Drawing.Point(8, 70);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(495, 58);
            this.groupBox5.TabIndex = 8;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Nome";
            // 
            // TboxNome
            // 
            this.TboxNome.Location = new System.Drawing.Point(6, 23);
            this.TboxNome.MaxLength = 100;
            this.TboxNome.Name = "TboxNome";
            this.TboxNome.Size = new System.Drawing.Size(483, 20);
            this.TboxNome.TabIndex = 6;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TboxCPF);
            this.groupBox3.Location = new System.Drawing.Point(8, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(243, 58);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "CPF";
            // 
            // TboxCPF
            // 
            this.TboxCPF.Location = new System.Drawing.Point(6, 23);
            this.TboxCPF.MaxLength = 11;
            this.TboxCPF.Name = "TboxCPF";
            this.TboxCPF.Size = new System.Drawing.Size(231, 20);
            this.TboxCPF.TabIndex = 6;
            this.TboxCPF.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.CbTipoPessoa);
            this.groupBox1.Location = new System.Drawing.Point(10, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(142, 58);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Física / Furídica";
            // 
            // CbTipoPessoa
            // 
            this.CbTipoPessoa.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbTipoPessoa.FormattingEnabled = true;
            this.CbTipoPessoa.Location = new System.Drawing.Point(12, 22);
            this.CbTipoPessoa.Name = "CbTipoPessoa";
            this.CbTipoPessoa.Size = new System.Drawing.Size(121, 21);
            this.CbTipoPessoa.TabIndex = 2;
            this.CbTipoPessoa.SelectionChangeCommitted += new System.EventHandler(this.CbTipoPessoa_SelectionChangeCommitted);
            // 
            // TboxIdCliente
            // 
            this.TboxIdCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TboxIdCliente.Location = new System.Drawing.Point(39, 12);
            this.TboxIdCliente.MaxLength = 7;
            this.TboxIdCliente.Name = "TboxIdCliente";
            this.TboxIdCliente.ReadOnly = true;
            this.TboxIdCliente.Size = new System.Drawing.Size(57, 26);
            this.TboxIdCliente.TabIndex = 1;
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
            // BtnSalvar
            // 
            this.BtnSalvar.Location = new System.Drawing.Point(382, 384);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(81, 28);
            this.BtnSalvar.TabIndex = 1;
            this.BtnSalvar.Text = "OK";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // BtnCancelar
            // 
            this.BtnCancelar.Location = new System.Drawing.Point(469, 384);
            this.BtnCancelar.Name = "BtnCancelar";
            this.BtnCancelar.Size = new System.Drawing.Size(81, 28);
            this.BtnCancelar.TabIndex = 2;
            this.BtnCancelar.Text = "Cancelar";
            this.BtnCancelar.UseVisualStyleBackColor = true;
            this.BtnCancelar.Click += new System.EventHandler(this.BtnCancelar_Click);
            // 
            // FormAtualizaCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 434);
            this.Controls.Add(this.BtnCancelar);
            this.Controls.Add(this.BtnSalvar);
            this.Controls.Add(this.tabControl1);
            this.Name = "FormAtualizaCliente";
            this.Text = "FormAtualizaCliente";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.TabControlTipoPessoa.ResumeLayout(false);
            this.TabPagePessoaJuridica.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.TabPagePessoaFisica.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox TboxIdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox CbTipoPessoa;
        private System.Windows.Forms.TextBox TboxCPF;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox TboxNome;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox TboxCNPJ;
        private System.Windows.Forms.TabControl TabControlTipoPessoa;
        private System.Windows.Forms.TabPage TabPagePessoaJuridica;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.TextBox TboxNomeFantasia;
        private System.Windows.Forms.TextBox TboxRazaoSocial;
        private System.Windows.Forms.TabPage TabPagePessoaFisica;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.TextBox TboxTelefone;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.TextBox TboxEmail;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.Button BtnCancelar;
    }
}