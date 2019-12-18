namespace PILA
{
    partial class frmEliminacion
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
            this.label1 = new System.Windows.Forms.Label();
            this.cmbEliminar = new System.Windows.Forms.Button();
            this.lbEliminar = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(87, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "E,ementos elimiados:";
            // 
            // cmbEliminar
            // 
            this.cmbEliminar.Location = new System.Drawing.Point(107, 26);
            this.cmbEliminar.Name = "cmbEliminar";
            this.cmbEliminar.Size = new System.Drawing.Size(75, 23);
            this.cmbEliminar.TabIndex = 2;
            this.cmbEliminar.Text = "Eliminar";
            this.cmbEliminar.UseVisualStyleBackColor = true;
            this.cmbEliminar.Click += new System.EventHandler(this.cmbEliminar_Click);
            // 
            // lbEliminar
            // 
            this.lbEliminar.FormattingEnabled = true;
            this.lbEliminar.Location = new System.Drawing.Point(90, 117);
            this.lbEliminar.Name = "lbEliminar";
            this.lbEliminar.Size = new System.Drawing.Size(120, 95);
            this.lbEliminar.TabIndex = 3;
            // 
            // frmEliminacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lbEliminar);
            this.Controls.Add(this.cmbEliminar);
            this.Controls.Add(this.label1);
            this.Name = "frmEliminacion";
            this.Text = "frmEliminacion";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cmbEliminar;
        private System.Windows.Forms.ListBox lbEliminar;

    }
}