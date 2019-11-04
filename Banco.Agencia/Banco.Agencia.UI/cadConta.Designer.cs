namespace Banco.Agencia.UI
{
    partial class cadConta
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
            this.cboTipoConta = new System.Windows.Forms.ComboBox();
            this.cboAge = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cboUF = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCli = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cboTipoConta
            // 
            this.cboTipoConta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoConta.FormattingEnabled = true;
            this.cboTipoConta.Location = new System.Drawing.Point(24, 119);
            this.cboTipoConta.Margin = new System.Windows.Forms.Padding(4);
            this.cboTipoConta.Name = "cboTipoConta";
            this.cboTipoConta.Size = new System.Drawing.Size(132, 24);
            this.cboTipoConta.TabIndex = 2;
            // 
            // cboAge
            // 
            this.cboAge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAge.FormattingEnabled = true;
            this.cboAge.Location = new System.Drawing.Point(178, 119);
            this.cboAge.Margin = new System.Windows.Forms.Padding(4);
            this.cboAge.Name = "cboAge";
            this.cboAge.Size = new System.Drawing.Size(132, 24);
            this.cboAge.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(178, 99);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 17);
            this.label7.TabIndex = 83;
            this.label7.Text = "Agência*:";
            // 
            // cboUF
            // 
            this.cboUF.AutoSize = true;
            this.cboUF.Location = new System.Drawing.Point(24, 99);
            this.cboUF.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.cboUF.Name = "cboUF";
            this.cboUF.Size = new System.Drawing.Size(106, 17);
            this.cboUF.TabIndex = 82;
            this.cboUF.Text = "Tipo de Conta*:";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Location = new System.Drawing.Point(22, 151);
            this.btnCadastrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(288, 28);
            this.btnCadastrar.TabIndex = 4;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 51);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 75;
            this.label2.Text = "Cliente*:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(269, 32);
            this.label1.TabIndex = 74;
            this.label1.Text = "Cadastro de Conta";
            // 
            // cboCli
            // 
            this.cboCli.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCli.FormattingEnabled = true;
            this.cboCli.Location = new System.Drawing.Point(24, 71);
            this.cboCli.Margin = new System.Windows.Forms.Padding(4);
            this.cboCli.Name = "cboCli";
            this.cboCli.Size = new System.Drawing.Size(286, 24);
            this.cboCli.TabIndex = 1;
            // 
            // cadConta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(334, 196);
            this.Controls.Add(this.cboCli);
            this.Controls.Add(this.cboTipoConta);
            this.Controls.Add(this.cboAge);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cboUF);
            this.Controls.Add(this.btnCadastrar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "cadConta";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastros: Conta";
            this.Load += new System.EventHandler(this.cadConta_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cboTipoConta;
        private System.Windows.Forms.ComboBox cboAge;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label cboUF;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCli;
    }
}