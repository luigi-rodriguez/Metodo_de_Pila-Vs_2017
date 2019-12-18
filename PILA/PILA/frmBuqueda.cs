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
    public partial class frmBuqueda : Form
    {
        public frmBuqueda()
        {
            InitializeComponent();
        }
        
        private void cmbBuscae_Click(object sender, EventArgs e)
        {
            string dato = txtDato.Text;
            txtDato.Text = "";
            txtDato.Focus();

            //Verificamos si la pila esta vacia
            if (frmPrincipal.Cima == -1)
            {
                MessageBox.Show("Pila esta vacia (UnderFlow)", "Advertencia", 
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);//adornar el mensaje
                return;
            }

            int i = 0;
            do
            {
                int res = string.Compare(dato, frmPrincipal.Pila[i]); //Codigo para comparar los elementos del arreglo con los de el dato del text box

                if (res == 0)
                {
                    lbBuscar.Items.Add(frmPrincipal.Pila[i]);
                    return;
                }
                i = i + 1;

            } while (i <= frmPrincipal.Cima);


            MessageBox.Show("No se encontraron datos con esas características");

        }
    }
}
