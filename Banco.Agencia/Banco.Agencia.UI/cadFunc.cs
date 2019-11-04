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
    public partial class cadFunc : System.Windows.Forms.Form
    {
        public cadFunc()
        {
            InitializeComponent();
        }

        private void limparCampos()
        {
            txtNome.Clear();
            txtCPF.Clear();
            txtRG.Clear();
            cboSexo.ResetText();
            mtxtDtNasc.Clear();
            cboUF.ResetText();
            cboCid.ResetText();
            txtDsEnd.Clear();
            cboAge.ResetText();
            cboCargo.ResetText();
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

        private bool ValidarCampoCPF(string campoValidar, string nomeCampo)
        {
            int cont = 0;
            for (int i = 0; i < campoValidar.Length; i++)
            {
                if (campoValidar[i] == '0' || campoValidar[i] == '1' || campoValidar[i] == '2' || campoValidar[i] == '3'
                    || campoValidar[i] == '4' || campoValidar[i] == '5' || campoValidar[i] == '6'
                    || campoValidar[i] == '7' || campoValidar[i] == '8' || campoValidar[i] == '9'
                    || campoValidar[i] == '/' || campoValidar[i] == '.' || campoValidar[i] == '-')
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

        private bool ValidarCampoRG(string campoValidar, string nomeCampo)
        {
            int cont = 0;
            for (int i = 0; i < campoValidar.Length; i++)
            {
                if (campoValidar[i] == '0' || campoValidar[i] == '1' || campoValidar[i] == '2' || campoValidar[i] == '3'
                    || campoValidar[i] == '4' || campoValidar[i] == '5' || campoValidar[i] == '6'
                    || campoValidar[i] == '7' || campoValidar[i] == '8' || campoValidar[i] == '9'
                    || campoValidar[i] == '/' || campoValidar[i] == '.' || campoValidar[i] == '-' || campoValidar[i] == 'X' || campoValidar[i] == 'x')
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

        private void cadFunc_Load(object sender, EventArgs e)
        {
            cboUF.ValueMember = "idUF";
            cboUF.DisplayMember = "nomeUF";
            DAO.Banco banco = new DAO.Banco();
            cboUF.DataSource = banco.retornarBancoUF();

            cboAge.ValueMember = "idAge";
            cboAge.DisplayMember = "nmAge";
            cboAge.DataSource = banco.retornarBancoAge();

            cboCargo.ValueMember = "idCargo";
            cboCargo.DisplayMember = "nmCargo";
            cboCargo.DataSource = banco.retornarBancoCargo();
        }

        private void cboUF_SelectedIndexChanged(object sender, EventArgs e)
        {
            string codUf = cboUF.SelectedValue.ToString();
            cboCid.ValueMember = "idCid";
            cboCid.DisplayMember = "nmCid";
            DAO.Banco banco = new DAO.Banco();
            cboCid.DataSource = banco.retornarBancoCid(codUf);
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (ValidarCampoString(txtNome.Text, "Nome") == false)
            {
                txtNome.Clear();
                txtNome.Focus();
                return;
            }
            if (ValidarCampoString(txtCPF.Text, "CPF") == false)
            {
                txtCPF.Clear();
                txtCPF.Focus();
                return;
            }
            if (ValidarCampoCPF(txtCPF.Text, "CPF") == false)
            {
                txtCPF.Clear();
                txtCPF.Focus();
                return;
            }
            if (ValidarCampoString(txtRG.Text, "RG") == false)
            {
                txtRG.Clear();
                txtRG.Focus();
                return;
            }
            if (ValidarCampoRG(txtRG.Text, "RG") == false)
            {
                txtRG.Clear();
                txtRG.Focus();
                return;
            }
            if (ValidarCampoString(cboSexo.Text, "Sexo") == false)
            {
                cboSexo.Focus();
                return;
            }
            if (ValidarCampoData(mtxtDtNasc.Text, "Data de Nascimento") == false)
            {
                mtxtDtNasc.Clear();
                mtxtDtNasc.Focus();
                return;
            }
            if (ValidarCampoString(cboUF.Text, "UF") == false)
            {
                cboUF.Focus();
                return;
            }
            if (ValidarCampoString(cboCid.Text, "Cidade") == false)
            {
                cboCid.Focus();
                return;
            }
            if (ValidarCampoString(txtDsEnd.Text, "Endereço") == false)
            {
                txtDsEnd.Focus();
                return;
            }
            if (ValidarCampoString(cboAge.Text, "Agência") == false)
            {
                cboAge.Focus();
                return;
            }
            if (ValidarCampoString(cboCargo.Text, "Cargo") == false)
            {
                cboCargo.Focus();
                return;
            }

            try
            {
                DAO.Banco banco = new DAO.Banco();
                banco.cadastrarFunc(txtNome.Text, txtCPF.Text, txtRG.Text, cboSexo.Text, DateTime.Parse(mtxtDtNasc.Text), int.Parse(cboCid.SelectedValue.ToString()), txtDsEnd.Text, int.Parse(cboAge.SelectedValue.ToString()), int.Parse(cboCargo.SelectedValue.ToString()));
                MessageBox.Show("Cadastro efetuado com sucesso!", "Banco");
                this.Hide();
                cadFunc form = new cadFunc();
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
