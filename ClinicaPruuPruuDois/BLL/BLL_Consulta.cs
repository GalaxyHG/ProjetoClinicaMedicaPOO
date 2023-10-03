using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaPruuPruuDois.DAL;
using ClinicaPruuPruuDois.DTO;

namespace ClinicaPruuPruuDois.BLL
{
    class BLL_Consulta
    {
        Conexao conn = new Conexao();
        public void InserirConsulta(DTO_Consulta Consulta)
        {
            try
            {
                string sql = $"INSERT INTO consulta VALUES (default,'{Consulta.NomeMedico}','{Consulta.NomePaciente}','{Consulta.Data}','{Consulta.Hora}')";
                conn.ExecutarComando(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
