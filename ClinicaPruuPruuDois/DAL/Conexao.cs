using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using MySql.Data;
using System.Data;
using System.Windows.Forms;

namespace ClinicaPruuPruuDois.DAL
{
    public class Conexao
    {
        MySqlConnection con = new MySqlConnection("server=localhost; database=ClinicaPruuPruu; uid=root; pwd=''");
        MySqlConnection conn;
        public void Conecta()
        {
            try
            {
                string sql = "server = localhost; " +
                "uid = root; " +
                "pwd = ''; " +
                "database = ClinicaPruuPruu";

                conn = new MySqlConnection(sql);
                conn.Open();
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possivel conectar ao banco de dados. " + ex.Message);
            }
        }

        public void ExecutarComando(string sql)
        {
            Conecta();

            try
            {
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                throw new Exception("A instrução não foi realizada.\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        public DataTable ExecutarConsulta(string sql)
        {
            try
            {
                Conecta();
                MySqlDataAdapter dados = new MySqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                dados.Fill(dt);

                return dt;
            }
            catch (MySqlException ex)
            {
                throw new Exception("Não foi possível executar a consulta solicitada.\n" + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }

        //public string ExecutaConsultaEspecifica(string sql)
        //{
        //    try
        //    {
        //        Conecta();
                
        //    }
        //    catch (MySqlException ex)
        //    {
        //        throw new Exception("Não foi possível executar a consulta solicitada.\n" + ex.Message);
        //    }
        //    finally
        //    {
        //        conn.Close();
        //    }
        //}

        public string consultaDado(string sql)
        {
            try
            {
                Conecta();
                MySqlCommand comando = new MySqlCommand(sql, conn);
                comando.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = comando.ExecuteReader();
                dr.Read();

                return dr.GetString(0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Esse paciente não existe!\n Tente novamente com outro CPF ou cadastre o paciente solicitado!\n", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw new Exception(ex.Message);
            }
        }
        
        public DataSet preencheCombo()
        {
            string tbMedico = "SELECT nome FROM medico";
            MySqlCommand cmdSalvar = new MySqlCommand(tbMedico, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmdSalvar);
            adpt.Fill(ds);
            return ds;
        }
        public void fechaConn()
        {
            con.Close();
        }

        public DataSet preencheComboConsulta()
        {
            string tbMedico = "SELECT idConsulta FROM consulta";
            MySqlCommand cmdSalvar = new MySqlCommand(tbMedico, con);
            con.Open();
            DataSet ds = new DataSet();
            MySqlDataAdapter adpt = new MySqlDataAdapter(cmdSalvar);
            adpt.Fill(ds);
            return ds;
        }
    }
}
