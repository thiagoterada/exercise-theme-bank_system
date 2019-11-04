namespace Banco.Agencia.UI
{
    partial class cadFunc
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
            this.label9 = new System.Windows.Forms.Label();
            this.txtDsEnd = new System.Windows.Forms.TextBox();
            this.cboCid = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.lblUF = new System.Windows.Forms.Label();
            this.mtxtDtNasc = new System.Windows.Forms.MaskedTextBox();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cboSexo = new System.Windows.Forms.ComboBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtRG = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.cboCargo = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.ComboBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 266);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 17);
            this.label9.TabIndex = 38;
            this.label9.Text = "Endereço*:";
            // 
            // txtDsEnd
            // 
            this.txtDsEnd.Location = new System.Drawing.Point(23, 286);
            this.txtDsEnd.Margin = new System.Windows.Forms.Padding(4);
            this.txtDsEnd.MaxLength = 500;
            this.txtDsEnd.Multiline = true;
            this.txtDsEnd.Name = "txtDsEnd";
            this.txtDsEnd.Size = new System.Drawing.Size(287, 52);
            this.txtDsEnd.TabIndex = 8;
            // 
            // cboCid
            // 
            this.cboCid.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCid.FormattingEnabled = true;
            this.cboCid.Location = new System.Drawing.Point(177, 233);
            this.cboCid.Margin = new System.Windows.Forms.Padding(4);
            this.cboCid.Name = "cboCid";
            this.cboCid.Size = new System.Drawing.Size(132, 24);
            this.cboCid.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(177, 213);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(61, 17);
            this.label7.TabIndex = 34;
            this.label7.Text = "Cidade*:";
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(23, 213);
            this.lblUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(35, 17);
            this.lblUF.TabIndex = 33;
            this.lblUF.Text = "UF*:";
            // 
            // mtxtDtNasc
            // 
            this.mtxtDtNasc.Location = new System.Drawing.Point(177, 177);
            this.mtxtDtNasc.Margin = new System.Windows.Forms.Padding(4);
            this.mtxtDtNasc.Mask = "00/00/0000";
            this.mtxtDtNasc.Name = "mtxtDtNasc";
            this.mtxtDtNasc.Size = new System.Drawing.Size(132, 22);
            this.mtxtDtNasc.TabIndex = 5;
            this.mtxtDtNasc.ValidatingType = typeof(System.DateTime);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(23, 400);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(288, 28);
            this.btnCadastrar.TabIndex = 11;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(177, 158);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 17);
            this.label6.TabIndex = 30;
            this.label6.Text = "Data de Nasc.*:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 158);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(48, 17);
            this.label5.TabIndex = 29;
            this.label5.Text = "Sexo*:";
            // 
            // cboSexo
            // 
            this.cboSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboSexo.FormattingEnabled = true;
            this.cboSexo.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cboSexo.Location = new System.Drawing.Point(23, 177);
            this.cboSexo.Margin = new System.Windows.Forms.Padding(4);
            this.cboSexo.Name = "cboSexo";
            this.cboSexo.Size = new System.Drawing.Size(132, 24);
            this.cboSexo.TabIndex = 4;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(23, 122);
            this.txtCPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtCPF.MaxLength = 14;
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(132, 22);
            this.txtCPF.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "CPF*:";
            // 
            // txtRG
            // 
            this.txtRG.Location = new System.Drawing.Point(177, 122);
            this.txtRG.Margin = new System.Windows.Forms.Padding(4);
            this.txtRG.MaxLength = 12;
            this.txtRG.Name = "txtRG";
            this.txtRG.Size = new System.Drawing.Size(132, 22);
            this.txtRG.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(177, 101);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 17);
            this.label3.TabIndex = 24;
            this.label3.Text = "RG*:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 47);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 23;
            this.label2.Text = "Nome*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 29);
            this.label1.TabIndex = 22;
            this.label1.Text = "Cadastro de Funcionário";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(23, 66);
            this.txtNome.Margin = new System.Windows.Forms.Padding(4);
            this.txtNome.MaxLength = 100;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(287, 22);
            this.txtNome.TabIndex = 1;
            // 
            // cboCargo
            // 
            this.cboCargo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCargo.FormattingEnabled = true;
            this.cboCargo.Location = new System.Drawing.Point(177, 368);
            this.cboCargo.Margin = new System.Windows.Forms.Padding(4);
            this.cboCargo.Name = "cboCargo";
            this.cboCargo.Size = new System.Drawing.Size(132, 24);
            this.cboCargo.TabIndex = 10;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(177, 348);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(55, 17);
            this.label10.TabIndex = 39;
            this.label10.Text = "Cargo*:";
            // 
            // cboAge
            // 
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(23, 368);
            this.cboAge.Margin = new System.Windows.Forms.Padding(4);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(132, 24);
            this.cboAge.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(23, 348);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 17);
            this.label11.TabIndex = 41;
            this.label11.Text = "Agência*:";
            // 
            // cboUF
            // 
            this.cboUF.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUF.FormattingEnabled = true;
            this.cboUF.Location = new System.Drawing.Point(23, 233);
            this.cboUF.Margin = new System.Windows.Forms.Padding(4);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(132, 24);
            this.cboUF.TabIndex = 6;
            this.cboUF.SelectedIndexChanged += new System.EventHandler(this.cboUF_SelectedIndexChanged);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(23, 432);
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(288, 28);
            this.btnLimpar.TabIndex = 42;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // cadFunc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(341, 473);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.cboAge);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cboCargo);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtDsEnd);
            this.Controls.Add(this.cboCid);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lblUF);
            this.Controls.Add(this.mtxtDtNasc);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cboSexo);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRG);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtNome);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "cadFunc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros: Funcionário";
            this.Load += new System.EventHandler(this.cadFunc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDsEnd;
        private System.Windows.Forms.ComboBox cboCid;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.MaskedTextBox mtxtDtNasc;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboSexo;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.ComboBox cboCargo;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox cboUF;
        private System.Windows.Forms.Button btnLimpar;
    }
}