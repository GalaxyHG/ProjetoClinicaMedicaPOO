using ClinicaPruuPruuDois.DTO;
using ClinicaPruuPruuDois.BLL;
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
    public partial class FrmCadastroPaciente : Form
    {
        public FrmCadastroPaciente()
        {
            InitializeComponent();
        }

        DTO_Paciente dto = new DTO_Paciente();
        BLL_Paciente bll = new BLL_Paciente();

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            if (txtCPF.Text != "" || txtNome.Text != "" || txtTelefone.Text != "")
            {
                dto.ConstroiDTO_Paciente(txtCPF.Text, txtNome.Text,txtTelefone.Text);
                bll.Inserir(dto);
                MessageBox.Show("Paciente cadastrado com sucesso!");
                LimpaCampos();
            }
            else
            {
                MessageBox.Show("Você não preencheu todos os campos!");
            }
        }

        public void LimpaCampos()
        {
            txtCPF.Text = "";
            txtNome.Text = "";
            txtTelefone.Text = "";
        }
    }
}
