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
    public partial class FrmDeletarMedico : Form
    {
        public FrmDeletarMedico()
        {
            InitializeComponent();
        }

        Conexao conn = new Conexao();

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM medico WHERE nome = '{cmbMedico.Text}'";
            conn.ExecutarComando(sql);
            MessageBox.Show($"Comando executado: {sql}.");
            MessageBox.Show("Médico deletado com sucesso!");
            preencheID(conn.preencheCombo());
        }

        private void FrmDeletarMedico_Load(object sender, EventArgs e)
        {
            preencheID(conn.preencheCombo());
        }

        public void preencheID(DataSet ds)
        {
            cmbMedico.DataSource = ds.Tables[0];
            cmbMedico.ValueMember = "nome";
            conn.fechaConn();
        }
    }
}
