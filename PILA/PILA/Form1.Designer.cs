namespace PILA
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben eliminar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.cmbInsercion = new System.Windows.Forms.Button();
            this.cmbRecorrido = new System.Windows.Forms.Button();
            this.cmbBuscar = new System.Windows.Forms.Button();
            this.cbmEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // cmbInsercion
            // 
            this.cmbInsercion.Location = new System.Drawing.Point(95, 41);
            this.cmbInsercion.Name = "cmbInsercion";
            this.cmbInsercion.Size = new System.Drawing.Size(75, 23);
            this.cmbInsercion.TabIndex = 0;
            this.cmbInsercion.Text = "Insercion";
            this.cmbInsercion.UseVisualStyleBackColor = true;
            this.cmbInsercion.Click += new System.EventHandler(this.cmbInsercion_Click);
            // 
            // cmbRecorrido
            // 
            this.cmbRecorrido.Location = new System.Drawing.Point(95, 70);
            this.cmbRecorrido.Name = "cmbRecorrido";
            this.cmbRecorrido.Size = new System.Drawing.Size(75, 23);
            this.cmbRecorrido.TabIndex = 1;
            this.cmbRecorrido.Text = "Recorrido";
            this.cmbRecorrido.UseVisualStyleBackColor = true;
            this.cmbRecorrido.Click += new System.EventHandler(this.button2_Click);
            // 
            // cmbBuscar
            // 
            this.cmbBuscar.Location = new System.Drawing.Point(95, 99);
            this.cmbBuscar.Name = "cmbBuscar";
            this.cmbBuscar.Size = new System.Drawing.Size(75, 23);
            this.cmbBuscar.TabIndex = 2;
            this.cmbBuscar.Text = "Búsqueda";
            this.cmbBuscar.UseVisualStyleBackColor = true;
            this.cmbBuscar.Click += new System.EventHandler(this.cmbBuscar_Click);
            // 
            // cbmEliminar
            // 
            this.cbmEliminar.Location = new System.Drawing.Point(95, 128);
            this.cbmEliminar.Name = "cbmEliminar";
            this.cbmEliminar.Size = new System.Drawing.Size(75, 23);
            this.cbmEliminar.TabIndex = 3;
            this.cbmEliminar.Text = "Eliminar";
            this.cbmEliminar.UseVisualStyleBackColor = true;
            this.cbmEliminar.Click += new System.EventHandler(this.cbmEliminar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(260, 196);
            this.Controls.Add(this.cbmEliminar);
            this.Controls.Add(this.cmbBuscar);
            this.Controls.Add(this.cmbRecorrido);
            this.Controls.Add(this.cmbInsercion);
            this.Name = "frmPrincipal";
            this.Text = "PILAS";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button cmbInsercion;
        private System.Windows.Forms.Button cmbRecorrido;
        private System.Windows.Forms.Button cmbBuscar;
        private System.Windows.Forms.Button cbmEliminar;
    }
}

