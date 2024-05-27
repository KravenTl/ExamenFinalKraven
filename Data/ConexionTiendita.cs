using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ExamenFinalProgramaciónIKraven.Data
{
    internal class ConexionTiendita
    {
        //Cadena de conexion a la base de datos (La tiendita)
        string connectionString = "Server=localhost;Database=db_universidad;Uid=root;Pwd=crocomodo";
        private MySqlConnection connection;

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

        //Método para cargar todos los productos y retornarlos como una DataTable 
        public DataTable CargarProductos()
        {
            DataTable productos = new DataTable();
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    connection.Open();
                    string sql = "SELECT * FROM Productos";
                    using (MySqlCommand command = new MySqlCommand(sql, connection))
                    {
                        using (MySqlDataAdapter adapter = new MySqlDataAdapter(command))
                        {
                            adapter.Fill(productos); // Llenar el DataTable con los resultados de la consulta
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error al leer los productos"+ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return productos;//Devolver el DataTable con los productos 
        }








    }
}
