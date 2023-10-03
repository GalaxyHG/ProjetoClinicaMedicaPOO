using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClinicaPruuPruuDois.DAL;

namespace ClinicaPruuPruuDois
{
    public partial class FrmViewPacientes : Form
    {
        Conexao conn = new Conexao();
        public FrmViewPacientes()
        {
            InitializeComponent();
        }

        private void FrmViewPacientes_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void ExibirDados()
        {
            string query = "SELECT * FROM paciente;";
            dtgPacientes.DataSource = conn.ExecutarConsulta(query);
        }
    }
}
