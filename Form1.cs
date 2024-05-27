using ExamenFinalProgramaciónIKraven.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenFinalProgramaciónIKraven
{
    public partial class Form1 : Form
    {
        private ConexionTiendita producto;//Declarar instancia de la clae ConexionTiendita
        public Form1()
        {
            InitializeComponent();

            producto = new ConexionTiendita();
        }

        //variable de tipo array que contiene las marcas de los productos de la tiendita
        private string[] marcasTiendita = {"Toledo, Pollo Rey"};

        private void buttonPrueba_Click(object sender, EventArgs e)
        {
            if (producto.ProbarConexion())
            {
                MessageBox.Show("Conexion exitosa");

            }
            else
            {
                MessageBox.Show("Ya valio :( ");
            }
        }

        private void buttonCargar_Click(object sender, EventArgs e)
        {
            producto.CargarProductos();
        }
    }
}
