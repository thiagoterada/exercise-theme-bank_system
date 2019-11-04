using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco.Agencia.UI
{
    public partial class cadConta : Form
    {
        public cadConta()
        {
            InitializeComponent();
        }

        private bool ValidarCampoString(string campoValidar, string nomeCampo)
        {
            if (campoValidar == "")
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!");
                return false;
            }
            else
            {
                return true;
            }
        }

        private void cadConta_Load(object sender, EventArgs e)
        {
            cboTipoConta.ValueMember = "idTipoConta";
            cboTipoConta.DisplayMember = "nmTipoConta";
            DAO.Banco banco = new DAO.Banco();
            cboTipoConta.DataSource = banco.retornarBancoTipoConta();

            cboCli.ValueMember = "idCli";
            cboCli.DisplayMember = "nmCli";
            cboCli.DataSource = banco.retornarBancoCli();

            cboAge.ValueMember = "idAge";
            cboAge.DisplayMember = "nmAge";
            cboAge.DataSource = banco.retornarBancoAge();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoString(cboCli.Text, "Cliente") == false)
            {
                cboCli.Focus();
                return;
            }
            if (ValidarCampoString(cboTipoConta.Text, "Tipo Conta") == false)
            {
                cboTipoConta.Focus();
                return;
            }
            if (ValidarCampoString(cboAge.Text, "Agência") == false)
            {
                cboAge.Focus();
                return;
            }

            try
            {
                DAO.Banco banco = new DAO.Banco();
                banco.cadastrarConta(int.Parse(cboTipoConta.SelectedValue.ToString()), int.Parse(cboCli.SelectedValue.ToString()), int.Parse(cboAge.SelectedValue.ToString()), DateTime.Today);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Banco");
                this.Hide();
                cadConta form = new cadConta();
                form.Show();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao efetuar o cadastro! \n" + erro.Message, "Banco");
            }
        }
    }
}
