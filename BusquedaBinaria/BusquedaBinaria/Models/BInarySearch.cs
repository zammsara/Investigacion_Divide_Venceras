using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaBinaria.Models
{
    public class BInarySearch
    {
        // Método para realizar la búsqueda binaria en un arreglo de enteros
        public int RealizarBusquedaBinaria(int[] arreglo, int objetivo)
        {
            return BusquedaBinariaRecursiva(arreglo, objetivo, 0, arreglo.Length - 1);
        }

        // Método auxiliar recursivo para realizar la búsqueda binaria
        private int BusquedaBinariaRecursiva(int[] arreglo, int objetivo, int izquierda, int derecha)
        {
            // Condición base para salir de la recursión si no se encuentra el valor
            if (izquierda > derecha)
                return -1; // El valor no se encuentra en el arreglo

            // Calcular el punto medio del rango actual
            int medio = izquierda + (derecha - izquierda) / 2;

            // Comprobar si el elemento medio es igual al objetivo
            if (arreglo[medio] == objetivo)
                return medio; // Valor encontrado
            // Si el valor medio es mayor que el objetivo, buscar en la mitad izquierda
            else if (arreglo[medio] > objetivo)
                return BusquedaBinariaRecursiva(arreglo, objetivo, izquierda, medio - 1);
            // Si el valor medio es menor que el objetivo, buscar en la mitad derecha
            else
                return BusquedaBinariaRecursiva(arreglo, objetivo, medio + 1, derecha);
        }
    }
}
