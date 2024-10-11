using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaQuickSort.models
{
    public class Producto
    {
        public string Nombre { get; set; }
        public double Precio { get; set; }

        // constructor
        public Producto(string nombre, double precio)
        {
            Nombre = nombre;
            Precio = precio;
        }

        // se sobre escribe ToString para mostrar el nombre y precio en el listbox
        public override string ToString()
        {
            return $"{Nombre} - C${Precio}";
        }
    }
}
