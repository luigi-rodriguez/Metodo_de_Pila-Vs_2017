namespace PILA
{
    partial class frmInsercion
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
            this.txtDato = new System.Windows.Forms.TextBox();
            this.cmbInsertar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(130, 47);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 0;
            // 
            // cmbInsertar
            // 
            this.cmbInsertar.Location = new System.Drawing.Point(43, 43);
            this.cmbInsertar.Name = "cmbInsertar";
            this.cmbInsertar.Size = new System.Drawing.Size(75, 23);
            this.cmbInsertar.TabIndex = 1;
            this.cmbInsertar.Text = "Insertar";
            this.cmbInsertar.UseVisualStyleBackColor = true;
            this.cmbInsertar.Click += new System.EventHandler(this.cmbInsertar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(50, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(130, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ingresar los ELEMENTOS";
            // 
            // frmInsercion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 112);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbInsertar);
            this.Controls.Add(this.txtDato);
            this.Name = "frmInsercion";
            this.Text = "Insercion en la PILA";
            this.Load += new System.EventHandler(this.frmInsercion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Button cmbInsertar;
        private System.Windows.Forms.Label label1;
    }
}