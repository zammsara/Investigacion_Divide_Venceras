using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AlgoritmoDeStrassen.Models;

namespace AlgoritmoDeStrassen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void lblA_Click(object sender, EventArgs e)
        {

        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            // Validar los datos antes de proceder
            if (!ValidarDatos())
            {
                return; // Si la validación falla, no continuar
            }

            // Si los datos son válidos, proceder con la multiplicación
            int a11 = int.Parse(tbA11.Text);
            int a12 = int.Parse(tbA12.Text);
            int a21 = int.Parse(tbA21.Text);
            int a22 = int.Parse(tbA22.Text);

            int b11 = int.Parse(tbB11.Text);
            int b12 = int.Parse(tbB12.Text);
            int b21 = int.Parse(tbB21.Text);
            int b22 = int.Parse(tbB22.Text);

            int[,] A = new int[,] { { a11, a12 }, { a21, a22 } };
            int[,] B = new int[,] { { b11, b12 }, { b21, b22 } };

            // Crear una instancia de la clase MatrixMultiplication
            MatrixMultiplication matrixMultiplication = new MatrixMultiplication();

            // Llamar al algoritmo de Strassen para multiplicar las matrices
            int[,] resultado = matrixMultiplication.Strassen(A, B);

            // Mostrar el resultado en el DataGridView
            MostrarResultadoEnDataGridView(resultado);
        }
        private void MostrarResultadoEnDataGridView(int[,] result)
        {
            // Limpiar el DataGridView antes de mostrar los nuevos datos
            dgvResult.Rows.Clear();
            dgvResult.Columns.Clear();

            // Definir las columnas del DataGridView (2 columnas para la matriz 2x2)
            dgvResult.Columns.Add("Col1", "Col1");
            dgvResult.Columns.Add("Col2", "Col2");

            // Agregar las filas al DataGridView con los valores de la matriz
            for (int i = 0; i < 2; i++)
            {
                // Crear una nueva fila con los valores de la matriz
                string[] row = new string[2];
                for (int j = 0; j < 2; j++)
                {
                    row[j] = result[i, j].ToString();
                }

                // Agregar la fila al DataGridView
                dgvResult.Rows.Add(row);
            }
        }
        private bool ValidarDatos()
        {
            // Verificar que todos los TextBox contengan datos
            if (string.IsNullOrWhiteSpace(tbA11.Text) ||
                string.IsNullOrWhiteSpace(tbA12.Text) ||
                string.IsNullOrWhiteSpace(tbA21.Text) ||
                string.IsNullOrWhiteSpace(tbA22.Text) ||
                string.IsNullOrWhiteSpace(tbB11.Text) ||
                string.IsNullOrWhiteSpace(tbB12.Text) ||
                string.IsNullOrWhiteSpace(tbB21.Text) ||
                string.IsNullOrWhiteSpace(tbB22.Text))
            {
                MessageBox.Show("Por favor ingresa todos los valores en las matrices.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Verificar que todos los valores ingresados sean números válidos
            if (!int.TryParse(tbA11.Text, out _) ||
                !int.TryParse(tbA12.Text, out _) ||
                !int.TryParse(tbA21.Text, out _) ||
                !int.TryParse(tbA22.Text, out _) ||
                !int.TryParse(tbB11.Text, out _) ||
                !int.TryParse(tbB12.Text, out _) ||
                !int.TryParse(tbB21.Text, out _) ||
                !int.TryParse(tbB22.Text, out _))
            {
                MessageBox.Show("Por favor ingresa solo números en las matrices.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
