using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenFinalProgramaciónIKraven.Data.Models;
using MySql.Data.MySqlClient;

namespace ExamenFinalProgramaciónIKraven.Data
{
    internal class ConexionTiendita
    {
        //Cadena de conexion a la base de datos (La tiendita)
        string connectionString = "Server=localhost;Database=ExamenFinalYourgen;Uid=root;Pwd=crocomodo";
        MySqlConnection connection;

        //Constructor para inicializar la conexion
        public ConexionTiendita()
        {
            connection= new MySqlConnection(connectionString);
        }

        //Metodo para probar si se logro conectar o no, a la base de datos
        public bool ProbarConexion()
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                try
                {
                    connection.Open();//Abrir la conexion con la base de datos
                    return true;//Funciono
                }
                catch (Exception)
                {
                    return false;//No funciono
                }
            }
        }


        //Metodo para leer los productos 
        public List<Producto> LeerProductos()
        {
            List<Producto> productos = new List<Producto>();

            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                string query = "SELECT * FROM productos";
                MySqlCommand cmd = new MySqlCommand(query, connection);

                try
                {
                    connection.Open();
                    MySqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        Producto producto = new Producto
                        (
                            id: reader.GetInt32("ID"),
                            nombre: reader.GetString("Nombre_del_Producto"),
                            marca: reader.GetString("Marca"),
                            fechadeingreso: reader.GetDateTime("Fecha_de_ingreso"),
                            cantidad: reader.GetInt32("Cantidad"),
                            precio: reader.GetDecimal("Precio"),
                            disponibles: reader.GetBoolean("Disponibles")
                        );

                        productos.Add(producto);
                    }
                    reader.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }

            return productos;
        }

        //Metodo para Buscar productos por Id
        public DataTable BuscarProducto(int id)
        {
            DataTable productos = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Productos WHERE ID=@id";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@id", id);
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(productos); // Llenar el DataTable con los resultados de la consulta
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al leer los productos por Id" + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return productos;//Devolver el DataTable con los productos
        }

        //Metodo para Buscar por Marca 
        public DataTable BuscarProducto(string marca)
        {
            DataTable productos = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Productos WHERE Marca like @marca";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        command.Parameters.AddWithValue("@marca","%"+marca+"%");
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(productos); // Llenar el DataTable con los resultados de la consulta
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar por marca " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return productos;//Devolver el DataTable con los productos 
        }


        //Metodo para insertar un producto
        public void Insertar(Producto producto)//Mando por parametros lo que quiero insertar en la tabla
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "INSERT INTO productos (Nombre_del_producto, Marca, Fecha_de_ingreso,Cantidad,Precio,Disponibles) VALUES (@Nombre_del_producto, @Marca, @Fecha_de_ingreso, @Cantidad, @Precio, @Disponibles)";
                    using (MySqlCommand cmd = new MySqlCommand(query, connection))
                    {
                        cmd.Parameters.AddWithValue("@Nombre", producto.Nombre);
                        cmd.Parameters.AddWithValue("@Marca", producto.Marca);
                        cmd.Parameters.AddWithValue("@Fecha_de_ingreso", producto.Fecha_de_ingreso);
                        cmd.Parameters.AddWithValue("@Cantidad", producto.Cantidad);
                        cmd.Parameters.AddWithValue("@Precio", producto.Precio);
                        cmd.Parameters.AddWithValue("@Disponibles", producto.Disponibles);
                        connection.Open();
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Eror al poner el nuevo producto en el congelador: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }
        }







    }
}
