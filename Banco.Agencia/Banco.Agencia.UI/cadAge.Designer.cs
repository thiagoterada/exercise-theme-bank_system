namespace Banco.Agencia.UI
{
    partial class cadAge
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
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.cboCid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtCEP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.chkSN = new System.Windows.Forms.CheckBox();
            this.txtNro = new System.Windows.Forms.TextBox();
            this.txtLogradouro = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCompl = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cboUF
            // 
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(24, 119);
            this.cboUF.Margin = new System.Windows.Forms.Padding(4);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(132, 24);
            this.cboUF.TabIndex = 2;
            this.cboUF.SelectedIndexChanged += new System.EventHandler(this.cboUF_SelectedIndexChanged);
            // 
            // cboCid
            // 
            this.cboCid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCid.FormattingEnabled = true;
            this.cboCid.Location = new System.Drawing.Point(178, 119);
            this.cboCid.Margin = new System.Windows.Forms.Padding(4);
            this.cboCid.Name = "cboCid";
            this.cboCid.Size = new System.Drawing.Size(132, 24);
            this.cboCid.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 57;
            this.label7.Text = "Cidade*:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(24, 99);
            this.lblUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 17);
            this.lblUF.TabIndex = 56;
            this.lblUF.Text = "UF*:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(22, 304);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(288, 28);
            this.btnCadastrar.TabIndex = 10;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(91, 17);
            this.label6.TabIndex = 53;
            this.label6.Text = "Logradouro*:";
            // 
            // txtCEP
            // 
            this.txtCEP.Location = new System.Drawing.Point(24, 172);
            this.txtCEP.Margin = new System.Windows.Forms.Padding(4);
            this.txtCEP.MaxLength = 9;
            this.txtCEP.Name = "txtCEP";
            this.txtCEP.Size = new System.Drawing.Size(132, 22);
            this.txtCEP.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 151);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 17);
            this.label4.TabIndex = 49;
            this.label4.Text = "CEP*:";
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(178, 172);
            this.txtBairro.Margin = new System.Windows.Forms.Padding(4);
            this.txtBairro.MaxLength = 100;
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(132, 22);
            this.txtBairro.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(178, 151);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 47;
            this.label3.Text = "Bairro*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 46;
            this.label2.Text = "Nome*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(299, 32);
            this.label1.TabIndex = 45;
            this.label1.Text = "Cadastro de Agência";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(24, 70);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 22);
            this.txtNome.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 206);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 17);
            this.label5.TabIndex = 66;
            this.label5.Text = "N°:";
            // 
            // chkSN
            // 
            this.chkSN.AutoSize = true;
            this.chkSN.Location = new System.Drawing.Point(241, 225);
            this.chkSN.Name = "chkSN";
            this.chkSN.Size = new System.Drawing.Size(59, 21);
            this.chkSN.TabIndex = 8;
            this.chkSN.Text = "S/N°";
            this.chkSN.UseVisualStyleBackColor = true;
            this.chkSN.CheckedChanged += new System.EventHandler(this.chkSN_CheckedChanged);
            // 
            // txtNro
            // 
            this.txtNro.Location = new System.Drawing.Point(178, 223);
            this.txtNro.Margin = new System.Windows.Forms.Padding(4);
            this.txtNro.Name = "txtNro";
            this.txtNro.Size = new System.Drawing.Size(53, 22);
            this.txtNro.TabIndex = 7;
            // 
            // txtLogradouro
            // 
            this.txtLogradouro.Location = new System.Drawing.Point(24, 223);
            this.txtLogradouro.Margin = new System.Windows.Forms.Padding(4);
            this.txtLogradouro.MaxLength = 100;
            this.txtLogradouro.Name = "txtLogradouro";
            this.txtLogradouro.Size = new System.Drawing.Size(132, 22);
            this.txtLogradouro.TabIndex = 6;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(23, 255);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 17);
            this.label8.TabIndex = 72;
            this.label8.Text = "Complemento:";
            // 
            // txtCompl
            // 
            this.txtCompl.Location = new System.Drawing.Point(23, 274);
            this.txtCompl.Margin = new System.Windows.Forms.Padding(4);
            this.txtCompl.MaxLength = 100;
            this.txtCompl.Name = "txtCompl";
            this.txtCompl.Size = new System.Drawing.Size(287, 22);
            this.txtCompl.TabIndex = 9;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(23, 340);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(288, 28);
            this.btnLimpar.TabIndex = 11;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cadAge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(332, 377);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCompl);
            this.Controls.Add(this.txtLogradouro);
            this.Controls.Add(this.txtNro);
            this.Controls.Add(this.chkSN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.cboCid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtCEP);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBairro);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Name = "cadAge";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros: Agência";
            this.Load += new System.EventHandler(this.cadAge_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.ComboBox cboCid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtCEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.CheckBox chkSN;
        private System.Windows.Forms.TextBox txtNro;
        private System.Windows.Forms.TextBox txtLogradouro;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCompl;
        private System.Windows.Forms.Button btnLimpar;
    }
}