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
    public partial class frmPrincipal : Form
    {
       
        //Variables Globales
        public static string[] Pila;
        public static int Cima;
        public static int MaxPila;
        public static int N;
        

        
        public frmPrincipal()
        {
            InitializeComponent();
            N = 4;
            Pila = new string[N]; //Areglo de 4 elemntos
            MaxPila = N - 1;
            Cima = -1;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmRecorrido Recorrido = new frmRecorrido();
            Recorrido.Show();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void cmbInsercion_Click(object sender, EventArgs e)
        {
            frmInsercion Insercion = new frmInsercion();
            Insercion.Show();
        }

        private void cmbBuscar_Click(object sender, EventArgs e)
        {
            frmBuqueda Busqueda = new frmBuqueda();
            Busqueda.Show();
        }

        private void cbmEliminar_Click(object sender, EventArgs e)
        {
            frmEliminacion Eliminacion = new frmEliminacion();
            Eliminacion.Show();
        }
    }
}
