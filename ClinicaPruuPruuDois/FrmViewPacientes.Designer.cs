namespace ClinicaPruuPruuDois
{
    partial class FrmViewPacientes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dtgPacientes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgPacientes
            // 
            this.dtgPacientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgPacientes.Location = new System.Drawing.Point(12, 12);
            this.dtgPacientes.Name = "dtgPacientes";
            this.dtgPacientes.Size = new System.Drawing.Size(510, 275);
            this.dtgPacientes.TabIndex = 0;
            // 
            // FrmViewPacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(529, 296);
            this.Controls.Add(this.dtgPacientes);
            this.Name = "FrmViewPacientes";
            this.Text = "FrmViewPacientes";
            this.Load += new System.EventHandler(this.FrmViewPacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgPacientes)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgPacientes;
    }
}