using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TiendaQuickSort.models;

namespace TiendaQuickSort
{
    public partial class Producto : Form
    {
        private List<models.Producto> productos;
        public Producto()
        {
            InitializeComponent();
            productos = new List<models.Producto>();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = tbNombre.Text;
            double precio;

            // Validamos que el precio sea un numero decimal valido
            if (double.TryParse(tbPrecio.Text, out precio))
            {
                // Creamos un nuevo producto y lo agregamos a la lista
                productos.Add(new models.Producto(nombre, precio));

                // Mostramos el producto en el ListBox
                lbProductos.Items.Add(productos[productos.Count - 1]);

                // Limpiamos los TextBox
                tbNombre.Clear();
                tbPrecio.Clear();
            }
            else
            {
                MessageBox.Show("Ingrese un precio valido");
            }

        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (productos.Count > 0)
            {
                // Aplicamos QuickSort
                QuickSort.Ordenar(productos, 0, productos.Count - 1);

                // Limpiamos el ListBox y mostramos los productos ordenados
                lbProductos.Items.Clear();
                foreach (var producto in productos)
                {
                    lbProductos.Items.Add(producto);
                }
            }
            else
            {
                MessageBox.Show("Debe haber al menos un producto para ordenar");
            }
        }
    }
}
