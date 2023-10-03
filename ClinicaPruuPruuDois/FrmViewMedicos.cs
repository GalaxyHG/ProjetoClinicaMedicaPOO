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
    public partial class FrmViewMedicos : Form
    {
        Conexao conn = new Conexao();
        public FrmViewMedicos()
        {
            InitializeComponent();
        }

        private void FrmViewMedicos_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void ExibirDados()
        {
            string query = "SELECT * FROM medico;";
            dtgMedicos.DataSource = conn.ExecutarConsulta(query);
        }
    }
}
