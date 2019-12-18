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
    public partial class frmRecorrido : Form
    {
        public frmRecorrido()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmbRecorrido_Click(object sender, EventArgs e)
        {
            //verificar si la pila esta vacia
            if (frmPrincipal.Cima == -1)
            { 
                MessageBox.Show("La pila esta vacia (UnderFlox)","Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation );
                return;
            }

            int i = 0;

            do
            {
                liRecorrido.Items.Add(frmPrincipal.Pila[i]);
                i = i + 1;
            } while (i <= frmPrincipal.Cima);


            

        }

        private void frmRecorrido_Load(object sender, EventArgs e)
        {

        }
    }
}
