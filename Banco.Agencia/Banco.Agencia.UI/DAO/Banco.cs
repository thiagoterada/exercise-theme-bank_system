using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace Banco.Agencia.UI.DAO
{
    class Banco
    {

        public DataTable retornarBancoUF()
        {
            MySqlConnection conn = new MySqlConnection(@"Server=localhost; Uid=root;Pwd=;Database=bd_agencia");
            conn.Open();
            MySqlCommand sc = new MySqlCommand("SELECT * FROM UF Order by nomeUF", conn);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idUF", typeof(string));
            dt.Columns.Add("nomeUF", typeof(string));
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public DataTable retornarBancoCid(string cdEstado)
        {
            MySqlConnection conn = new MySqlConnection(@"Server=localhost; Uid=root;Pwd=;Database=bd_agencia;");
            conn.Open();

            MySqlCommand sc = new MySqlCommand("SELECT * FROM CIDADE where idUF=" + cdEstado + " Order by nmCid", conn);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idCid", typeof(string));
            dt.Columns.Add("nmCid", typeof(string));
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public DataTable retornarBancoTipoConta()
        {
            MySqlConnection conn = new MySqlConnection(@"Server=localhost; Uid=root;Pwd=;Database=bd_agencia;");
            conn.Open();
            MySqlCommand sc = new MySqlCommand("SELECT * FROM TIPO_CONTA Order by nmTipoConta", conn);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idTipoConta", typeof(string));
            dt.Columns.Add("nmTipoConta", typeof(string));
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public DataTable retornarBancoCli()
        {
            MySqlConnection conn = new MySqlConnection(@"Server=localhost; Uid=root;Pwd=;Database=bd_agencia;");
            conn.Open();
            MySqlCommand sc = new MySqlCommand("SELECT * FROM CLIENTE Order by nmCli", conn);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idCli", typeof(string));
            dt.Columns.Add("nmCli", typeof(string));
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public DataTable retornarBancoAge()
        {
            MySqlConnection conn = new MySqlConnection(@"Server=localhost; Uid=root;Pwd=;Database=bd_agencia;");
            conn.Open();
            MySqlCommand sc = new MySqlCommand("SELECT * FROM AGENCIA Order by nmAge", conn);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idAge", typeof(string));
            dt.Columns.Add("nmAge", typeof(string));
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public DataTable retornarBancoCargo()
        {
            MySqlConnection conn = new MySqlConnection(@"Server=localhost; Uid=root;Pwd=;Database=bd_agencia;");
            conn.Open();
            MySqlCommand sc = new MySqlCommand("SELECT * FROM CARGO_FUNC Order by nmCargo", conn);
            MySqlDataReader reader;
            reader = sc.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Columns.Add("idCargo", typeof(string));
            dt.Columns.Add("nmCargo", typeof(string));
            dt.Load(reader);
            conn.Close();
            return dt;
        }

        public void cadastrarAgencia(string nome, int idCid, string cep, string bairro, string logra, string nro, string compl)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=bd_agencia";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `bd_agencia`.`AGENCIA` (`nmAge`, `idCidAge`, `cepAge`, `bairroAge`, `logradouro`, `nroAge`, `complAge`) VALUES ('"+nome+"', '"+idCid+"', '"+cep+"', '"+bairro+"', '"+logra+"', '"+nro+"', '"+compl+"');");
            mscommand.Connection = msc;
            mscommand.ExecuteNonQuery(); 
            msc.Close();
        }

        public void cadastrarCliente(string nome, string cpf, string rg, string sexo, DateTime dtn, int idCid, string dsEnd)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=bd_agencia";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `bd_agencia`.`CLIENTE` (`nmCli`, `cpfCli`, `rgCli`, `sexoCli`, `dtNascCli`, `idCid`, `dsEndCli`) VALUES ('"+nome+"', '" +cpf+ "', '"+rg+"', '"+sexo+"', '"+dtn.ToString("yyyy-MM-dd")+"', '"+idCid+"', '"+dsEnd+"');");
            mscommand.Connection = msc;
            mscommand.ExecuteNonQuery();
            msc.Close();
        }

        public void cadastrarFunc(string nome, string cpf, string rg, string sexo, DateTime dtn, int idCid, string dsEnd, int idAge, int idCargo)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=bd_agencia";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `bd_agencia`.`FUNCIONARIO` (`nmFunc`, `cpfFunc`, `rgFunc`, `sexoFunc`, `dtNascFunc`, `idCid`, `dsEndFunc`, `idAge`, `idCargo`) VALUES ('" + nome + "', '" + cpf + "', '" + rg + "', '" + sexo + "', '" + dtn.ToString("yyyy-MM-dd") + "', '" + idCid + "', '" + dsEnd + "', '"+idAge+"', '"+idCargo+"');");
            mscommand.Connection = msc;
            mscommand.ExecuteNonQuery();
            msc.Close();
        }

        public void cadastrarConta(int idTipoConta, int idCli, int idAge, DateTime dtAbertura)
        {
            MySqlConnection msc = new MySqlConnection();
            msc.ConnectionString = "server=localhost;User Id=root;password='';database=bd_agencia";
            msc.Open();
            MySqlCommand mscommand = new MySqlCommand("INSERT INTO `bd_agencia`.`CONTA` (`idTipoConta`, `idCli`, `idAge`, `dtAberturaConta`) VALUES ('"+idTipoConta+"', '"+idCli+"', '"+idAge+"', '"+dtAbertura.ToString("yyyy-MM-dd")+"');");
            mscommand.Connection = msc;
            mscommand.ExecuteNonQuery();
            msc.Close();
        }
    }
}
