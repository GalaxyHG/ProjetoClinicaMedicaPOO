using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPruuPruuDois.DTO
{
    class DTO_Paciente
    {
        private string cpf, nome, telefone;

        public void ConstroiDTO_Paciente(string cpf, string nome, string telefone)
        {
            this.CPF = cpf;
            this.Nome = nome;
            this.Telefone = telefone;
        }

        public string CPF { get => cpf; set => cpf = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Telefone { get => telefone; set => telefone = value; }
    }
}
