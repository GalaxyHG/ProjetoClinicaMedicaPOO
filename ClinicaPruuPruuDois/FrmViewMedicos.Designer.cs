namespace ClinicaPruuPruuDois
{
    partial class FrmViewMedicos
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
            this.dtgMedicos = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicos)).BeginInit();
            this.SuspendLayout();
            // 
            // dtgMedicos
            // 
            this.dtgMedicos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgMedicos.Location = new System.Drawing.Point(12, 12);
            this.dtgMedicos.Name = "dtgMedicos";
            this.dtgMedicos.Size = new System.Drawing.Size(511, 270);
            this.dtgMedicos.TabIndex = 0;
            // 
            // FrmViewMedicos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(535, 294);
            this.Controls.Add(this.dtgMedicos);
            this.Name = "FrmViewMedicos";
            this.Text = "FrmViewMedicos";
            this.Load += new System.EventHandler(this.FrmViewMedicos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgMedicos)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dtgMedicos;
    }
}