using ClinicaPruuPruuDois.BLL;
using ClinicaPruuPruuDois.DTO;
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
    public partial class FrmCadastroMedico : Form
    {
        public FrmCadastroMedico()
        {
            InitializeComponent();
        }

        DTO_Medico dto = new DTO_Medico();
        BLL_Medico bll = new BLL_Medico();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if(txtCrm.Text != "" || txtNome.Text != "" || cmbEspecialidade.Text != "Selecione")
            {
                dto.ConstroiDTO_Medico(txtCrm.Text, txtNome.Text, cmbEspecialidade.Text);
                bll.Inserir(dto);
                MessageBox.Show("Médico cadastrado com sucesso!");
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Você não preencheu todos os campos!");
            }
        }

        public void LimpaCampos()
        {
            txtCrm.Text = "";
            txtNome.Text = "";
            cmbEspecialidade.Text = "Selecione";
        }
    }
}
