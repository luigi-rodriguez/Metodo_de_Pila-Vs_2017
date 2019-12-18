using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PILA
{
    public partial class frmInsercion : Form
    {
        public frmInsercion()
        {
            InitializeComponent();
        }

        private void cmbInsertar_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            txtDato.Text = "";
            txtDato.Focus();

            if (frmPrincipal.Cima == frmPrincipal.MaxPila)
            {
                MessageBox.Show("La PILA está llena (Overflow)", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            frmPrincipal.Cima = frmPrincipal.Cima + 1;
            frmPrincipal.Pila[frmPrincipal.Cima] = dato; //Insertando el dato al arreglo de tipo pila

        }

        private void frmInsercion_Load(object sender, EventArgs e)
        {

        }
    }
}
