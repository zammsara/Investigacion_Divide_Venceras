using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort_Ejemplo.models
{
    // Clase que contiene la logica de Merge Sort
    public class MergeSortLogica
    {
        // Metodo principal de Merge Sort
        public void MergeSort(int[] array, int left, int right)
        {
            // Verificamos si el subarray es mayor a 1 elemento
            if (left < right)
            {
                // Encontramos el punto medio
                int middle = (left + right) / 2;

                // Llamamos recursivamente para ordenar la primera mitad
                MergeSort(array, left, middle);

                // Llamamos recursivamente para ordenar la segunda mitad
                MergeSort(array, middle + 1, right);

                // Combinamos las dos mitades ordenadas
                Merge(array, left, middle, right);
            }
        }

        // Metodo que combina dos subarrays ordenados en un array final
        private void Merge(int[] array, int left, int middle, int right)
        {
            // Calculamos el tamaño de los subarreglos a combinar
            int n1 = middle - left + 1; //n1 longitud de la primera mitad
            int n2 = right - middle;    //n2 longitud de la segunda mitad

            // Creamos los arreglos temporales para almacenar las dos mitades
            int[] L = new int[n1]; //L almacena los elementos de la primera mitad
            int[] R = new int[n2]; //R almacena los elementos de la segunda mitad

            // Copian los datos del array original a los subarrays temporales
            Array.Copy(array, left, L, 0, n1); //left hasta middle
            Array.Copy(array, middle + 1, R, 0, n2); //middle+1 hasta right

            // Inicializamos los indices para recorrer ambos subarrays
            int i = 0, j = 0, k = left; // i recorre L, j recorre R, k es para colocar los elementos
                                        // en la posicion correcta dentro del array original

            // Mezclamos los subarrays ordenadamente en el array original
            while (i < n1 && j < n2)
            {
                if (L[i] >= R[j])  // Orden de mayor a menor
                {
                    array[k] = L[i];
                    i++;
                }
                else
                {
                    array[k] = R[j];
                    j++;
                }
                k++;
            }

            // Copiamos los elementos restantes de L (si los hay)
            while (i < n1)
            {
                array[k] = L[i];
                i++;
                k++;
            }

            // Copiamos los elementos restantes de R (si los hay)
            while (j < n2)
            {
                array[k] = R[j];
                j++;
                k++;
            }
        }
    }
}
    
