using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmoDeStrassen.Models
{
    public class MatrixMultiplication
    {
        // Algoritmo de Strassen para multiplicar matrices 2x2
        public int[,] Strassen(int[,] A, int[,] B)
        {
            // Tamaño de las matrices (2x2)
            int a11 = A[0, 0], a12 = A[0, 1], a21 = A[1, 0], a22 = A[1, 1];
            int b11 = B[0, 0], b12 = B[0, 1], b21 = B[1, 0], b22 = B[1, 1];

            // Cálculo de los 7 productos de Strassen
            int M1 = (a11 + a22) * (b11 + b22);
            int M2 = (a21 + a22) * b11;
            int M3 = a11 * (b12 - b22);
            int M4 = a22 * (b21 - b11);
            int M5 = (a11 + a12) * b22;
            int M6 = (a21 - a11) * (b11 + b12);
            int M7 = (a12 - a22) * (b21 + b22);

            // Calcular los elementos de la matriz resultado
            int c11 = M1 + M4 - M5 + M7;
            int c12 = M3 + M5;
            int c21 = M2 + M4;
            int c22 = M1 - M2 + M3 + M6;

            // Retornar la matriz resultante
            return new int[,]
            {
            { c11, c12 },
            { c21, c22 }
            };
        }
    }
}
