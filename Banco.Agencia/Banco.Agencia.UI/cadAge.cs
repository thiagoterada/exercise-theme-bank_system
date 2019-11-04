using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Banco.Agencia.UI
{
    public partial class cadAge : System.Windows.Forms.Form
    {
        public cadAge()
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

        private bool ValidarCampoNum(string campoValidar, string nomeCampo)
        {
            try
            {
                int.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!");
                return false;
            }
        }

        private bool ValidarCampoData(string campoValidar, string nomeCampo)
        {
            try
            {
                DateTime.Parse(campoValidar);
                return true;
            }
            catch (Exception)
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!");
                return false;
            }
        }

        private bool ValidarCampoCEP(string campoValidar, string nomeCampo)
        {
            int cont = 0;
            for (int i = 0; i < campoValidar.Length; i++)
            {
                if (campoValidar[i] == '1' || campoValidar[i] == '2' || campoValidar[i] == '3'
                    || campoValidar[i] == '4' || campoValidar[i] == '5' || campoValidar[i] == '6'
                    || campoValidar[i] == '7' || campoValidar[i] == '8' || campoValidar[i] == '9'
                    || campoValidar[i] == '0' || campoValidar[i] == '-')
                {
                }
                else
                {
                    cont = 1;
                }
            }
            if (cont == 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show("Campo " + nomeCampo + " Inválido!");
                return false;
            }
        }

        private void chkSN_CheckedChanged(object sender, EventArgs e)
        {
            if(chkSN.Checked == true)
            {
                txtNro.Text = string.Empty;
                txtNro.Enabled = false;
            }
            else
            {
                txtNro.Enabled = true;
            }
        }

        private void cadAge_Load(object sender, EventArgs e)
        {
            try
            {
                cboUF.ValueMember = "idUF";
                cboUF.DisplayMember = "nomeUF";
                DAO.Banco banco = new DAO.Banco();
                cboUF.DataSource = banco.retornarBancoUF();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na conexão com o banco de dados! \n" + erro.Message, "Banco");
            }
        }

        private void cboUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string codUf = cboUF.SelectedValue.ToString();
                cboCid.ValueMember = "idCid";
                cboCid.DisplayMember = "nmCid";
                DAO.Banco banco = new DAO.Banco();
                cboCid.DataSource = banco.retornarBancoCid(codUf);
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro na conexão com o banco de dados! \n" + erro.Message, "Banco");
            }
        }

        private void limparCampos()
        {
            txtNome.Clear();
            cboUF.ResetText();
            cboCid.ResetText();
            txtCEP.Clear();
            txtBairro.Clear();
            txtLogradouro.Clear();
            txtNro.Clear();
            txtCompl.Clear();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            if (ValidarCampoString(cboUF.Text, "UF") == false)
            {
                cboUF.ResetText();
                cboUF.Focus();
                return;
            }
            if (ValidarCampoString(cboCid.Text, "Cidade") == false)
            {
                cboCid.ResetText();
                cboCid.Focus();
                return;
            }
            if (ValidarCampoString(txtCEP.Text, "CEP") == false)
            {
                txtCEP.Clear();
                txtCEP.Focus();
                return;
            }
            if (ValidarCampoCEP(txtCEP.Text, "CEP") == false)
            {
                txtCEP.Clear();
                txtCEP.Focus();
                return;
            }
            if (ValidarCampoString(txtBairro.Text, "Bairro") == false)
            {
                txtBairro.Clear();
                txtBairro.Focus();
                return;
            }
            if (ValidarCampoString(txtLogradouro.Text, "Logradouro") == false)
            {
                txtLogradouro.Clear();
                txtLogradouro.Focus();
                return;
            }
            if(chkSN.Checked != true)
            {
                if (ValidarCampoString(txtNro.Text, "Número") == false)
                {
                    txtNro.Clear();
                    txtNro.Focus();
                    return;
                }
                if (ValidarCampoNum(txtNro.Text, "Número") == false)
                {
                    txtNro.Clear();
                    txtNro.Focus();
                    return;
                }
            }
            try
            {
                DAO.Banco banco = new DAO.Banco();
                banco.cadastrarAgencia(txtNome.Text, int.Parse(cboCid.SelectedValue.ToString()), txtCEP.Text, txtBairro.Text, txtLogradouro.Text, txtNro.Text, txtCompl.Text);
                MessageBox.Show("Cadastro efetuado com sucesso!", "Banco");
                this.Hide();
                cadAge form = new cadAge();
                form.Show();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao efetuar o cadastro! \n" + erro.Message, "Banco");
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            limparCampos();
        }
    }
}
