using Org.BouncyCastle.Asn1.IsisMtt.X509;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamenFinalProgramaciónIKraven.Data.Models
{
    internal class Producto
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Marca { get; set; }
        public DateTime Fecha_de_ingreso { get; set; }
        public int Cantidad { get; set; }
        public decimal Precio { get; set; }
        public bool Disponibles { get; set; }

        //Constructor de la clase producto, sin parametros
        public Producto( ) { }
        
        //Constructor de la clase prorductos con parametros
        public Producto(int id, string nombre, string marca, DateTime fechadeingreso, int cantidad, decimal precio, bool disponibles)
        {
            Id = id;
            Nombre= nombre;
            Marca= marca;
            Fecha_de_ingreso= fechadeingreso;
            Cantidad = cantidad;
            Precio = precio;
            Disponibles= disponibles;
        }




    }
}
