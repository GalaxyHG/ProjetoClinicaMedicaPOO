using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPruuPruuDois
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void médicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroMedico form = new FrmCadastroMedico();
            form.ShowDialog();
        }

        private void pacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroPaciente form = new FrmCadastroPaciente();
            form.ShowDialog();
        }

        private void marcarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmCadastroConsulta form = new FrmCadastroConsulta();
            form.ShowDialog();
        }

        private void consultasMarcadasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewConsultas form = new FrmViewConsultas();
            form.ShowDialog();
        }

        private void médicosCadastradosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewMedicos form = new FrmViewMedicos();
            form.ShowDialog();
        }

        private void pacientesCaaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmViewPacientes form = new FrmViewPacientes();
            form.ShowDialog();
        }

        private void pacienteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeletarPaciente form = new FrmDeletarPaciente();
            form.ShowDialog();
        }

        private void médicoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmDeletarMedico form = new FrmDeletarMedico();
            form.ShowDialog();
        }

        private void consultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmDeletarConsulta form = new FrmDeletarConsulta();
            form.ShowDialog();
        }

        private void atualizarUmCadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAtualizarCadastros form = new FrmAtualizarCadastros();
            form.ShowDialog();
        }
    }
}
