using ClinicaPruuPruuDois.DAL;
using ClinicaPruuPruuDois.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPruuPruuDois.BLL
{
    class BLL_Paciente
    {
        Conexao conn = new Conexao();

        public void Inserir(DTO_Paciente Paciente)
        {
            try
            {
                string sql = $"INSERT INTO paciente VALUES ('{Paciente.CPF}', '{Paciente.Nome}', '{Paciente.Telefone}')";
                conn.ExecutarComando(sql);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
