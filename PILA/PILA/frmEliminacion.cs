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
    public partial class frmEliminacion : Form
    {
        public frmEliminacion()
        {
            InitializeComponent();
        }

        private void cmbEliminar_Click(object sender, EventArgs e)
        {
            if (frmPrincipal.Cima == -1)
            {
                MessageBox.Show("No hay elementos en la Pila");
                return;
            }

            string Dato = frmPrincipal.Pila[frmPrincipal.Cima];
            frmPrincipal.Cima = frmPrincipal.Cima - 1;
            lbEliminar.Items.Add(Dato);
        }
    }
}
