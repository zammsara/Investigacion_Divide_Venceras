using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TiendaQuickSort.models
{
    public class QuickSort
    {
        // Metodo que implementa QuickSort
        public static void Ordenar(List<Producto> productos, int izquierda, int derecha)
        {
            if (izquierda < derecha)
            {
                int indicePivote = Particionar(productos, izquierda, derecha);

                // Ordenamos recursivamente las sublistas
                Ordenar(productos, izquierda, indicePivote - 1);
                Ordenar(productos, indicePivote + 1, derecha);
            }
        }

        // Metodo para particionar la lista segun el pivote
        private static int Particionar(List<Producto> productos, int izquierda, int derecha)
        {
            double pivote = productos[derecha].Precio;
            int i = izquierda - 1;

            for (int j = izquierda; j < derecha; j++)
            {
                if (productos[j].Precio < pivote)
                {
                    i++;
                    Intercambiar(productos, i, j);
                }
            }

            Intercambiar(productos, i + 1, derecha);
            return i + 1;
        }

        // Metodo para intercambiar productos en la lista
        private static void Intercambiar(List<Producto> productos, int i, int j)
        {
            Producto temp = productos[i];
            productos[i] = productos[j];
            productos[j] = temp;
        }
    }
}
