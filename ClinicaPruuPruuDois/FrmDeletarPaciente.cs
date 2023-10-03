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
    public partial class FrmDeletarPaciente : Form
    {
        public FrmDeletarPaciente()
        {
            InitializeComponent();
        }

        Conexao conn = new Conexao();

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            string sql = $"DELETE FROM paciente WHERE cpf = '{txtCPF.Text}'";
            conn.ExecutarComando(sql);
            MessageBox.Show($"Comando executado: {sql}.");
            MessageBox.Show("Paciente deletado com sucesso!");
        }
    }
}
