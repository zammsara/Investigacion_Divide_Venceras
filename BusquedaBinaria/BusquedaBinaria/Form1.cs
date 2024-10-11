using BusquedaBinaria.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BusquedaBinaria
{
    public partial class Form1 : Form
    {
        private BInarySearch binarySearch;
        public Form1()
        {
            InitializeComponent();
            binarySearch = new BInarySearch();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                // Convertir el contenido de tbArreglo a un arreglo de enteros
                int[] arregloOriginal = tbArreglo.Text.Split(',')
                                                      .Select(int.Parse)
                                                      .ToArray();

                // Obtener el valor a buscar
                int valorABuscar = int.Parse(tbValorBuscar.Text);

                // Ordenar una copia del arreglo para la búsqueda binaria
                int[] arregloOrdenado = (int[])arregloOriginal.Clone();
                Array.Sort(arregloOrdenado);

                // Realizar la búsqueda binaria en el arreglo ordenado
                int indiceResultadoOrdenado = binarySearch.RealizarBusquedaBinaria(arregloOrdenado, valorABuscar);

                // Obtener la posición del valor en el arreglo original
                int indiceResultadoOriginal = Array.IndexOf(arregloOriginal, valorABuscar);

                // Mostrar el resultado en lblResult
                lblResult.Text = indiceResultadoOrdenado != -1
                    ? $"Valor encontrado en la posición original {indiceResultadoOriginal}"
                    : "Valor no encontrado en el arreglo.";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
            finally
            {
                // Limpiar los campos después de la búsqueda
                tbArreglo.Clear();
                tbValorBuscar.Clear();
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
    
}
