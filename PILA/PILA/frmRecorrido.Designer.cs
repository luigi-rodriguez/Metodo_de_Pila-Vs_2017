namespace PILA
{
    partial class frmRecorrido
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
            this.cmbRecorrido = new System.Windows.Forms.Button();
            this.liRecorrido = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbRecorrido
            // 
            this.cmbRecorrido.Location = new System.Drawing.Point(97, 35);
            this.cmbRecorrido.Name = "cmbRecorrido";
            this.cmbRecorrido.Size = new System.Drawing.Size(75, 23);
            this.cmbRecorrido.TabIndex = 0;
            this.cmbRecorrido.Text = "Recorrido";
            this.cmbRecorrido.UseVisualStyleBackColor = true;
            this.cmbRecorrido.Click += new System.EventHandler(this.cmbRecorrido_Click);
            // 
            // liRecorrido
            // 
            this.liRecorrido.FormattingEnabled = true;
            this.liRecorrido.Location = new System.Drawing.Point(68, 101);
            this.liRecorrido.Name = "liRecorrido";
            this.liRecorrido.Size = new System.Drawing.Size(138, 134);
            this.liRecorrido.TabIndex = 1;
            this.liRecorrido.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(89, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Recorrido de la Pila";
            // 
            // frmRecorrido
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.liRecorrido);
            this.Controls.Add(this.cmbRecorrido);
            this.Name = "frmRecorrido";
            this.Text = "Recorrido de la Pila";
            this.Load += new System.EventHandler(this.frmRecorrido_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cmbRecorrido;
        private System.Windows.Forms.ListBox liRecorrido;
        private System.Windows.Forms.Label label1;
    }
}