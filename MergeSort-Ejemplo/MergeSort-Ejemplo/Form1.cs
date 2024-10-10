using MergeSort_Ejemplo.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MergeSort_Ejemplo
{
    public partial class Form1 : Form
    {
        // Arreglo de calificaciones de estudiantes
        private int[] calificaciones = { 85, 92, 74, 88, 90, 69, 73, 95, 80, 77 };

        // Instancia de la clase que contiene la logica del Merge Sort
        private MergeSortLogica mergeSortLogica = new MergeSortLogica();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            lbCalificaciones.Items.Clear();  // Limpiamos el ListBox antes de cargar las califcaciones

            // Agregamos las calificaciones al ListBox
            foreach (int calificacion in calificaciones)
            {
                lbCalificaciones.Items.Add("Estudiante: " + calificacion);
            }
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            // Llamamos al metodo MergeSort para ordenar el arreglo
            mergeSortLogica.MergeSort(calificaciones, 0, calificaciones.Length - 1);

            // Limpiamos el ListBox para mostrar el arreglo ordenado
            lbCalificaciones.Items.Clear();

            // Agregamos las calificaciones ordenadas al ListBox
            foreach (int calificacion in calificaciones)
            {
                lbCalificaciones.Items.Add("Estudiante: " + calificacion);
            }

            // Mostramos un mensaje confirmando que las calificaciones fueron ordenadas
            MessageBox.Show("Las calificaciones han sido ordenadas exitosamente.");
        }
    }
}
