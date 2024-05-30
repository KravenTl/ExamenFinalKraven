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
        ConexionTiendita producto = new ConexionTiendita(); // Varible de instancia de la clase ConexionTiendita
        Producto prd = new Producto();
        List<Producto> inventario;

        //Lista que contiene las marcas de la tiendita
        private List<string> marcasTiendita = new List<string> { "Toledo", "Pollo Rey" };
        //Lista que contiene las marcas
        private List<string> nombresProducto = new List<string> { "Salchicha Hot Dog 10 U","Salchicha Hot Dog 54 U","Tortitas de pollo 4u","Alitas Barbacoa 200g","Carne Prensada","Tortitas de carne 1518g"};
        public Form1()
        {
            InitializeComponent();
            // Cargar todo en los comboBox al iniciar el formulario
            CargaralosComboBox();
            
        }


        // Para cargar las marcas y nombres en los comboBox
        private void CargaralosComboBox()
        {
            comboBoxMarca.DataSource = marcasTiendita; // Le asignamos el valor de la lista de marcas
            comboBoxMarca.SelectedIndex = -1; // Para que no haya ninguna selección inicial

            comboBoxNombre.DataSource = nombresProducto; // Le asignamos el valor de la lista de nombres
            comboBoxNombre.SelectedIndex = -1; // Para que no haya ninguna selección inicial

            // Asignar el evento SelectedIndexChanged a ambos combo boxes
            comboBoxMarca.SelectedIndexChanged += ComboBoxMarca_SelectedIndexChanged;
            comboBoxNombre.SelectedIndexChanged += ComboBoxNombre_SelectedIndexChanged;
        }

        // Para que al seleccionar algo en el comboBoxMarca se actualice el textBoxMarca
        private void ComboBoxMarca_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxMarca.SelectedIndex != -1)
            {
                textBoxMarca.Text = comboBoxMarca.SelectedItem.ToString();
            }
        }

        // Para que al seleccionar algo en el comboBoxNombre se actualice el textBoxNombre
        private void ComboBoxNombre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxNombre.SelectedIndex != -1)
            {
                textBoxNombre.Text = comboBoxNombre.SelectedItem.ToString();
            }
        }
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
            prd.ID = int.Parse(textBoxId.Text);
            dataGridView1.DataSource = producto.BuscarProducto(prd.ID);
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

        //Paa insertar un nuevo producto
        private void buttonInsertar_Click(object sender, EventArgs e)
        {
            prd.Nombre= textBoxNombre.Text;
            prd.Marca = textBoxMarca.Text;
            prd.Fecha_de_ingreso = DateTime.Now;
            prd.Cantidad = int.Parse(textBoxCantidad.Text);
            prd.Precio=decimal.Parse(textBoxPrecio.Text);
            prd.Disponibles= checkBoxDisponibles.Checked;
            producto.Insertar(prd);
        }

        //Para Actualizar un producto
        private void buttonActualizar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxId.Text)) { 
            prd.ID = int.Parse(textBoxId.Text);
            prd.Nombre = textBoxNombre.Text;
            prd.Marca = textBoxMarca.Text;
            prd.Cantidad = int.Parse(textBoxCantidad.Text);
            prd.Precio = decimal.Parse(textBoxPrecio.Text);
            prd.Disponibles = checkBoxDisponibles.Checked;
            producto.Actualizar(prd);
            dataGridView1.DataSource = producto.LeerProductos();
            MessageBox.Show("Se actualizo correctamente");
            }
            else
            {
                MessageBox.Show("Ingrese la Id del Producto que desea actualizar");
            }
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxId.Text))
            {
                prd.ID=int.Parse(textBoxId.Text);
                producto.EliminarProducto(prd);
                MessageBox.Show("Se elimino correctamente");
            }else
            {
                MessageBox.Show("Ingrese la Id del producto que desea Eliminar");
            }
        }
    }
}
