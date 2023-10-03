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
    public partial class FrmAtualizarCadastros : Form
    {
        public FrmAtualizarCadastros()
        {
            InitializeComponent();
        }

        private void rdbMedico_CheckedChanged(object sender, EventArgs e)
        {
            if(cmbMedico.Enabled == true)
            {
                cmbMedico.Enabled = false;
            }
            else
            {
                cmbMedico.Enabled = true;
            }
        }
    }
}
