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
    public partial class FrmViewConsultas : Form
    {
        Conexao conn = new Conexao();
        public FrmViewConsultas()
        {
            InitializeComponent();
        }

        private void FrmViewConsultas_Load(object sender, EventArgs e)
        {
            ExibirDados();
        }

        private void ExibirDados()
        {
            string query = "SELECT * FROM consulta;";
            dtgConsultas.DataSource = conn.ExecutarConsulta(query);
        }
    }
}
