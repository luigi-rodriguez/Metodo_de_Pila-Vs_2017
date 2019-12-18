namespace PILA
{
    partial class frmBuqueda
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBuscae = new System.Windows.Forms.Button();
            this.lbBuscar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // txtDato
            // 
            this.txtDato.Location = new System.Drawing.Point(145, 38);
            this.txtDato.Name = "txtDato";
            this.txtDato.Size = new System.Drawing.Size(100, 20);
            this.txtDato.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(127, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Ingresa el Dato a Buscar:";
            // 
            // cmbBuscae
            // 
            this.cmbBuscae.Location = new System.Drawing.Point(145, 76);
            this.cmbBuscae.Name = "cmbBuscae";
            this.cmbBuscae.Size = new System.Drawing.Size(75, 23);
            this.cmbBuscae.TabIndex = 2;
            this.cmbBuscae.Text = "Buscar";
            this.cmbBuscae.UseVisualStyleBackColor = true;
            this.cmbBuscae.Click += new System.EventHandler(this.cmbBuscae_Click);
            // 
            // lbBuscar
            // 
            this.lbBuscar.FormattingEnabled = true;
            this.lbBuscar.Location = new System.Drawing.Point(75, 120);
            this.lbBuscar.Name = "lbBuscar";
            this.lbBuscar.Size = new System.Drawing.Size(170, 121);
            this.lbBuscar.TabIndex = 3;
            // 
            // frmBuqueda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbBuscar);
            this.Controls.Add(this.cmbBuscae);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDato);
            this.Name = "frmBuqueda";
            this.Text = "Buqueda en PILA";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtDato;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmbBuscae;
        private System.Windows.Forms.ListBox lbBuscar;
    }
}