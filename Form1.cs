using ExamenFinalProgramaciónIKraven.Data;
using ExamenFinalProgramaciónIKraven.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ExamenFinalProgramaciónIKraven
{
    public partial class Form1 : Form
    {
        ConexionTiendita producto= new ConexionTiendita(); // Varible de instancia de la clase ConexionTiendita
        Producto prd= new Producto();
        List<Producto> inventario;

        public Form1()
        {
            InitializeComponent();
        }

        //variable de tipo array que contiene las marcas de los productos de la tiendita
        private string[] marcasTiendita = {"Toledo, Pollo Rey"};

        //Para probar la conexion
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

        //Para leer todos los datos de la tabla
        private void buttonCargar_Click(object sender, EventArgs e)
        {
            inventario = producto.LeerProductos();
            dataGridView1.DataSource = inventario;
        }

        //Para buscar por Id o Marca
        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxId.Text))//Si el textBox de la id NO esta vacio o nulo  
            { 
            int id = int.Parse(textBoxId.Text);
            dataGridView1.DataSource = producto.BuscarProducto(id);
            textBoxId.Clear();
            }
            else if (!string.IsNullOrWhiteSpace(textBoxMarca.Text))//Si el texBox de la marca NO esta vacio o nulo
            {
                string marca=textBoxMarca.Text; 
                dataGridView1.DataSource = producto.BuscarProducto(marca);
                textBoxMarca.Clear();
            }
            else
            {
                MessageBox.Show("Por favor ingrese la Marca o Id del producto que desea buscar");
            }
        }
    }
}
