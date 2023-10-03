using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClinicaPruuPruuDois.DTO
{
    class DTO_Consulta
    {
        private string nomeMedico, nomePaciente, data, hora;

        public void ConstroiDTO_Consulta(string nomeMedico, string nomePaciente, string data, string hora)
        {
            this.nomeMedico = nomeMedico;
            this.nomePaciente = nomePaciente;
            this.data = data;
            this.hora = hora;
        }

        public string NomeMedico { get => nomeMedico; set => nomeMedico = value; }
        public string NomePaciente { get => nomePaciente; set => nomePaciente = value; }
        public string Data { get => data; set => data = value; }
        public string Hora { get => hora; set => hora = value; }
    }
}
