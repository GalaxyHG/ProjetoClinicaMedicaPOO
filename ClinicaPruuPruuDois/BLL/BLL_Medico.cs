using ClinicaPruuPruuDois.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClinicaPruuPruuDois.DTO;
using System.Data;

namespace ClinicaPruuPruuDois.BLL
{
    class BLL_Medico
    {

        Conexao conn = new Conexao();

        public void Inserir(DTO_Medico Medico)
        {
            try
            {
                string sql = $"INSERT INTO medico VALUES (default, '{Medico.Crm}', '{Medico.Nome}', '{Medico.Especialidade}')";
                conn.ExecutarComando(sql);
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
    }
}
