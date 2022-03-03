namespace CadastroDeClientes
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnPessoaFisica = new System.Windows.Forms.Button();
            this.btnPessoaJuridica = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtMostraPessoaJuridica = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNomePessoaJuridica = new System.Windows.Forms.TextBox();
            this.txtEnderecoPessoaJuridica = new System.Windows.Forms.TextBox();
            this.txtCNPJ = new System.Windows.Forms.TextBox();
            this.txtIE = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNomePessoaFisica = new System.Windows.Forms.TextBox();
            this.txtEnderecoPessoaFisica = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtMostraPessoaFisica = new System.Windows.Forms.TextBox();
            this.painelPessoaFisica = new System.Windows.Forms.Panel();
            this.painelPessoaJuridica = new System.Windows.Forms.Panel();
            this.painelPessoaFisica.SuspendLayout();
            this.painelPessoaJuridica.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPessoaFisica
            // 
            this.btnPessoaFisica.Location = new System.Drawing.Point(108, 35);
            this.btnPessoaFisica.Name = "btnPessoaFisica";
            this.btnPessoaFisica.Size = new System.Drawing.Size(81, 61);
            this.btnPessoaFisica.TabIndex = 0;
            this.btnPessoaFisica.Text = "Pessoa Física";
            this.btnPessoaFisica.UseVisualStyleBackColor = true;
            this.btnPessoaFisica.Click += new System.EventHandler(this.btnPessoaFisica_Click);
            // 
            // btnPessoaJuridica
            // 
            this.btnPessoaJuridica.Location = new System.Drawing.Point(244, 35);
            this.btnPessoaJuridica.Name = "btnPessoaJuridica";
            this.btnPessoaJuridica.Size = new System.Drawing.Size(81, 61);
            this.btnPessoaJuridica.TabIndex = 0;
            this.btnPessoaJuridica.Text = "Pessoa Jurídica";
            this.btnPessoaJuridica.UseVisualStyleBackColor = true;
            this.btnPessoaJuridica.Click += new System.EventHandler(this.btnPessoaJuridica_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(385, 35);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(81, 61);
            this.btnSalvar.TabIndex = 0;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtMostraPessoaJuridica
            // 
            this.txtMostraPessoaJuridica.Location = new System.Drawing.Point(20, 96);
            this.txtMostraPessoaJuridica.Multiline = true;
            this.txtMostraPessoaJuridica.Name = "txtMostraPessoaJuridica";
            this.txtMostraPessoaJuridica.Size = new System.Drawing.Size(487, 158);
            this.txtMostraPessoaJuridica.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Endereço:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "CNPJ:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(316, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "IE:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNomePessoaJuridica
            // 
            this.txtNomePessoaJuridica.Location = new System.Drawing.Point(77, 16);
            this.txtNomePessoaJuridica.Name = "txtNomePessoaJuridica";
            this.txtNomePessoaJuridica.Size = new System.Drawing.Size(430, 20);
            this.txtNomePessoaJuridica.TabIndex = 2;
            // 
            // txtEnderecoPessoaJuridica
            // 
            this.txtEnderecoPessoaJuridica.Location = new System.Drawing.Point(77, 41);
            this.txtEnderecoPessoaJuridica.Name = "txtEnderecoPessoaJuridica";
            this.txtEnderecoPessoaJuridica.Size = new System.Drawing.Size(430, 20);
            this.txtEnderecoPessoaJuridica.TabIndex = 2;
            this.txtEnderecoPessoaJuridica.TextChanged += new System.EventHandler(this.txtEndereco_TextChanged);
            // 
            // txtCNPJ
            // 
            this.txtCNPJ.Location = new System.Drawing.Point(77, 67);
            this.txtCNPJ.Name = "txtCNPJ";
            this.txtCNPJ.Size = new System.Drawing.Size(165, 20);
            this.txtCNPJ.TabIndex = 3;
            this.txtCNPJ.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // txtIE
            // 
            this.txtIE.Location = new System.Drawing.Point(342, 67);
            this.txtIE.Name = "txtIE";
            this.txtIE.Size = new System.Drawing.Size(165, 20);
            this.txtIE.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Nome:";
            // 
            // txtNomePessoaFisica
            // 
            this.txtNomePessoaFisica.Location = new System.Drawing.Point(69, 17);
            this.txtNomePessoaFisica.Name = "txtNomePessoaFisica";
            this.txtNomePessoaFisica.Size = new System.Drawing.Size(419, 20);
            this.txtNomePessoaFisica.TabIndex = 1;
            // 
            // txtEnderecoPessoaFisica
            // 
            this.txtEnderecoPessoaFisica.Location = new System.Drawing.Point(69, 43);
            this.txtEnderecoPessoaFisica.Name = "txtEnderecoPessoaFisica";
            this.txtEnderecoPessoaFisica.Size = new System.Drawing.Size(419, 20);
            this.txtEnderecoPessoaFisica.TabIndex = 1;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(302, 74);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(184, 20);
            this.txtCPF.TabIndex = 1;
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(69, 74);
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(181, 20);
            this.txtRG.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 46);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Endereço:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 2;
            this.label7.Text = "RG:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(266, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "CPF:";
            // 
            // txtMostraPessoaFisica
            // 
            this.txtMostraPessoaFisica.Location = new System.Drawing.Point(22, 119);
            this.txtMostraPessoaFisica.Multiline = true;
            this.txtMostraPessoaFisica.Name = "txtMostraPessoaFisica";
            this.txtMostraPessoaFisica.Size = new System.Drawing.Size(478, 146);
            this.txtMostraPessoaFisica.TabIndex = 3;
            // 
            // painelPessoaFisica
            // 
            this.painelPessoaFisica.Controls.Add(this.txtNomePessoaFisica);
            this.painelPessoaFisica.Controls.Add(this.label8);
            this.painelPessoaFisica.Controls.Add(this.label7);
            this.painelPessoaFisica.Controls.Add(this.label5);
            this.painelPessoaFisica.Controls.Add(this.txtRG);
            this.painelPessoaFisica.Controls.Add(this.txtEnderecoPessoaFisica);
            this.painelPessoaFisica.Controls.Add(this.txtCPF);
            this.painelPessoaFisica.Controls.Add(this.label6);
            this.painelPessoaFisica.Controls.Add(this.txtMostraPessoaFisica);
            this.painelPessoaFisica.Location = new System.Drawing.Point(12, 102);
            this.painelPessoaFisica.Name = "painelPessoaFisica";
            this.painelPessoaFisica.Size = new System.Drawing.Size(517, 277);
            this.painelPessoaFisica.TabIndex = 4;
            this.painelPessoaFisica.Visible = false;
            this.painelPessoaFisica.Paint += new System.Windows.Forms.PaintEventHandler(this.painelPessoaFisica_Paint);
            // 
            // painelPessoaJuridica
            // 
            this.painelPessoaJuridica.Controls.Add(this.label1);
            this.painelPessoaJuridica.Controls.Add(this.txtIE);
            this.painelPessoaJuridica.Controls.Add(this.txtMostraPessoaJuridica);
            this.painelPessoaJuridica.Controls.Add(this.label2);
            this.painelPessoaJuridica.Controls.Add(this.txtCNPJ);
            this.painelPessoaJuridica.Controls.Add(this.label3);
            this.painelPessoaJuridica.Controls.Add(this.label4);
            this.painelPessoaJuridica.Controls.Add(this.txtEnderecoPessoaJuridica);
            this.painelPessoaJuridica.Controls.Add(this.txtNomePessoaJuridica);
            this.painelPessoaJuridica.Location = new System.Drawing.Point(12, 99);
            this.painelPessoaJuridica.Name = "painelPessoaJuridica";
            this.painelPessoaJuridica.Size = new System.Drawing.Size(517, 277);
            this.painelPessoaJuridica.TabIndex = 5;
            this.painelPessoaJuridica.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 397);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPessoaJuridica);
            this.Controls.Add(this.btnPessoaFisica);
            this.Controls.Add(this.painelPessoaJuridica);
            this.Controls.Add(this.painelPessoaFisica);
            this.Name = "Form1";
            this.Text = "Form1";
            this.painelPessoaFisica.ResumeLayout(false);
            this.painelPessoaFisica.PerformLayout();
            this.painelPessoaJuridica.ResumeLayout(false);
            this.painelPessoaJuridica.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnPessoaFisica;
        private System.Windows.Forms.Button btnPessoaJuridica;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtIE;
        private System.Windows.Forms.TextBox txtCNPJ;
        private System.Windows.Forms.TextBox txtEnderecoPessoaJuridica;
        private System.Windows.Forms.TextBox txtNomePessoaJuridica;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMostraPessoaJuridica;
        private System.Windows.Forms.TextBox txtMostraPessoaFisica;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtEnderecoPessoaFisica;
        private System.Windows.Forms.TextBox txtNomePessoaFisica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel painelPessoaFisica;
        private System.Windows.Forms.Panel painelPessoaJuridica;
    }
}

