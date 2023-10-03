using ClinicaPruuPruuDois.DTO;
using ClinicaPruuPruuDois.BLL;
using ClinicaPruuPruuDois.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicaPruuPruuDois
{
    public partial class FrmCadastroConsulta : Form
    {
        public FrmCadastroConsulta()
        {
            InitializeComponent();
        }

        DTO_Consulta dto = new DTO_Consulta();
        BLL_Consulta bll = new BLL_Consulta();
        Conexao conn = new Conexao();

        private void FrmCadastroConsulta_Load(object sender, EventArgs e)
        {
            preencheID(conn.preencheCombo());
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            string cpf = "", nomePaciente = "";
            cpf = txtCPF.Text;
            nomePaciente = pegaNome(cpf);
            dto.ConstroiDTO_Consulta(cmbMedico.Text, nomePaciente, dtConsulta.Text, hrConsulta.Text);
            bll.InserirConsulta(dto);
            MessageBox.Show("Consulta cadastrada com sucesso!");
            LimpaCampos();
        }

        public void LimpaCampos()
        {
            txtCPF.Text = "";
            cmbMedico.Text = "Selecione";
        }
        public void preencheID(DataSet ds)
        {
            cmbMedico.DataSource = ds.Tables[0];
            cmbMedico.ValueMember = "nome";
            conn.fechaConn();
        }

        public string pegaNome(string cpf)
        {
            string query;
            query = $"SELECT nome FROM paciente WHERE cpf = '{cpf}'";
            return conn.consultaDado(query);
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
