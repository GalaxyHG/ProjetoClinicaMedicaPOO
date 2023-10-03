namespace ClinicaPruuPruuDois
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visualizarCadastrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.médicosCadastradosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacientesCaaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasMarcadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deletarUmCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pacienteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.médicoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.atualizarUmCadastroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(476, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarToolStripMenuItem,
            this.visualizarCadastrosToolStripMenuItem,
            this.deletarUmCadastroToolStripMenuItem,
            this.atualizarUmCadastroToolStripMenuItem,
            this.marcarConsultaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastrarToolStripMenuItem
            // 
            this.cadastrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicoToolStripMenuItem,
            this.pacienteToolStripMenuItem});
            this.cadastrarToolStripMenuItem.Name = "cadastrarToolStripMenuItem";
            this.cadastrarToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.cadastrarToolStripMenuItem.Text = "Cadastrar";
            // 
            // médicoToolStripMenuItem
            // 
            this.médicoToolStripMenuItem.Name = "médicoToolStripMenuItem";
            this.médicoToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.médicoToolStripMenuItem.Text = "Médico";
            this.médicoToolStripMenuItem.Click += new System.EventHandler(this.médicoToolStripMenuItem_Click);
            // 
            // pacienteToolStripMenuItem
            // 
            this.pacienteToolStripMenuItem.Name = "pacienteToolStripMenuItem";
            this.pacienteToolStripMenuItem.Size = new System.Drawing.Size(119, 22);
            this.pacienteToolStripMenuItem.Text = "Paciente";
            this.pacienteToolStripMenuItem.Click += new System.EventHandler(this.pacienteToolStripMenuItem_Click);
            // 
            // visualizarCadastrosToolStripMenuItem
            // 
            this.visualizarCadastrosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.médicosCadastradosToolStripMenuItem,
            this.pacientesCaaToolStripMenuItem,
            this.consultasMarcadasToolStripMenuItem});
            this.visualizarCadastrosToolStripMenuItem.Name = "visualizarCadastrosToolStripMenuItem";
            this.visualizarCadastrosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.visualizarCadastrosToolStripMenuItem.Text = "Visualizar Cadastros";
            // 
            // médicosCadastradosToolStripMenuItem
            // 
            this.médicosCadastradosToolStripMenuItem.Name = "médicosCadastradosToolStripMenuItem";
            this.médicosCadastradosToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.médicosCadastradosToolStripMenuItem.Text = "Médicos Cadastrados";
            this.médicosCadastradosToolStripMenuItem.Click += new System.EventHandler(this.médicosCadastradosToolStripMenuItem_Click);
            // 
            // pacientesCaaToolStripMenuItem
            // 
            this.pacientesCaaToolStripMenuItem.Name = "pacientesCaaToolStripMenuItem";
            this.pacientesCaaToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.pacientesCaaToolStripMenuItem.Text = "Pacientes Cadastrados";
            this.pacientesCaaToolStripMenuItem.Click += new System.EventHandler(this.pacientesCaaToolStripMenuItem_Click);
            // 
            // consultasMarcadasToolStripMenuItem
            // 
            this.consultasMarcadasToolStripMenuItem.Name = "consultasMarcadasToolStripMenuItem";
            this.consultasMarcadasToolStripMenuItem.Size = new System.Drawing.Size(192, 22);
            this.consultasMarcadasToolStripMenuItem.Text = "Consultas Marcadas";
            this.consultasMarcadasToolStripMenuItem.Click += new System.EventHandler(this.consultasMarcadasToolStripMenuItem_Click);
            // 
            // deletarUmCadastroToolStripMenuItem
            // 
            this.deletarUmCadastroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pacienteToolStripMenuItem1,
            this.médicoToolStripMenuItem1,
            this.consultaToolStripMenuItem});
            this.deletarUmCadastroToolStripMenuItem.Name = "deletarUmCadastroToolStripMenuItem";
            this.deletarUmCadastroToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.deletarUmCadastroToolStripMenuItem.Text = "Deletar um Cadastro";
            // 
            // pacienteToolStripMenuItem1
            // 
            this.pacienteToolStripMenuItem1.Name = "pacienteToolStripMenuItem1";
            this.pacienteToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.pacienteToolStripMenuItem1.Text = "Paciente";
            this.pacienteToolStripMenuItem1.Click += new System.EventHandler(this.pacienteToolStripMenuItem1_Click);
            // 
            // médicoToolStripMenuItem1
            // 
            this.médicoToolStripMenuItem1.Name = "médicoToolStripMenuItem1";
            this.médicoToolStripMenuItem1.Size = new System.Drawing.Size(121, 22);
            this.médicoToolStripMenuItem1.Text = "Médico";
            this.médicoToolStripMenuItem1.Click += new System.EventHandler(this.médicoToolStripMenuItem1_Click);
            // 
            // consultaToolStripMenuItem
            // 
            this.consultaToolStripMenuItem.Name = "consultaToolStripMenuItem";
            this.consultaToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.consultaToolStripMenuItem.Text = "Consulta";
            this.consultaToolStripMenuItem.Click += new System.EventHandler(this.consultaToolStripMenuItem_Click);
            // 
            // atualizarUmCadastroToolStripMenuItem
            // 
            this.atualizarUmCadastroToolStripMenuItem.Name = "atualizarUmCadastroToolStripMenuItem";
            this.atualizarUmCadastroToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.atualizarUmCadastroToolStripMenuItem.Text = "Atualizar um Cadastro";
            this.atualizarUmCadastroToolStripMenuItem.Click += new System.EventHandler(this.atualizarUmCadastroToolStripMenuItem_Click);
            // 
            // marcarConsultaToolStripMenuItem
            // 
            this.marcarConsultaToolStripMenuItem.Name = "marcarConsultaToolStripMenuItem";
            this.marcarConsultaToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.marcarConsultaToolStripMenuItem.Text = "Marcar Consulta";
            this.marcarConsultaToolStripMenuItem.Click += new System.EventHandler(this.marcarConsultaToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel1.Controls.Add(this.lblTitulo);
            this.panel1.Location = new System.Drawing.Point(0, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(476, 87);
            this.panel1.TabIndex = 1;
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monotype Corsiva", 36F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(74, 17);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(334, 57);
            this.lblTitulo.TabIndex = 2;
            this.lblTitulo.Text = "Cliníca Pruu Pruu";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(476, 165);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcarConsultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visualizarCadastrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem médicosCadastradosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacientesCaaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasMarcadasToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.ToolStripMenuItem deletarUmCadastroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pacienteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem médicoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem consultaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem atualizarUmCadastroToolStripMenuItem;
    }
}

