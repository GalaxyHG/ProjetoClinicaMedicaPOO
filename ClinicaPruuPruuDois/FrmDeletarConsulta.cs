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
    public partial class FrmDeletarConsulta : Form
    {
        public FrmDeletarConsulta()
        {
            InitializeComponent();
        }

        Conexao conn = new Conexao();
        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM consulta WHERE idConsulta = '{cmbConsulta.Text}'";
            conn.ExecutarComando(sql);
            MessageBox.Show($"Comando executado: {sql}.");
            MessageBox.Show("Consulta deletada com sucesso!");
        }

        private void FrmDeletarConsulta_Load(object sender, EventArgs e)
        {
            preencheID(conn.preencheComboConsulta());
        }
        public void preencheID(DataSet ds)
        {
            cmbConsulta.DataSource = ds.Tables[0];
            cmbConsulta.ValueMember = "idConsulta";
            conn.fechaConn();
        }
    }
}
