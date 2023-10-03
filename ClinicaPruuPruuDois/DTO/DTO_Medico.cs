using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPruuPruuDois.DTO
{
    class DTO_Medico
    {
        private string crm, nome, especialidade;

        public void ConstroiDTO_Medico(string crm, string nome, string especialidade)
        {
            this.crm = crm;
            this.nome = nome;
            this.especialidade = especialidade;
        }

        public string Crm { get => crm; set => crm = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Especialidade { get => especialidade; set => especialidade = value; }
    }
}
