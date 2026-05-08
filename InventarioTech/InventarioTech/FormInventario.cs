using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventarioTech
{
    public partial class FormInventario : Form
    {
        List<Producto> listaProductos = new List<Producto>();

        public FormInventario()
        {
            InitializeComponent();
        }

        private void btnEliminar_Load(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto p = new Producto();

            p.Codigo = txtCodigo.Text;
            p.Nombre = txtNombre.Text;
            p.Precio = Convert.ToDouble(txtPrecio.Text);
            p.Cantidad = Convert.ToInt32(txtCantidad.Text);

            listaProductos.Add(p);

            dgvProductos.DataSource = null;
            dgvProductos.DataSource = listaProductos;

            MessageBox.Show("Producto agregado correctamente");
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                listaProductos.RemoveAt(dgvProductos.CurrentRow.Index);

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductos;

                MessageBox.Show("Producto eliminado");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            foreach (Producto p in listaProductos)
            {
                if (p.Codigo == txtCodigo.Text)
                {
                    txtNombre.Text = p.Nombre;
                    txtPrecio.Text = p.Precio.ToString();
                    txtCantidad.Text = p.Cantidad.ToString();

                    MessageBox.Show("Producto encontrado");
                }
            }
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow != null)
            {
                int index = dgvProductos.CurrentRow.Index;

                listaProductos[index].Codigo = txtCodigo.Text;
                listaProductos[index].Nombre = txtNombre.Text;
                listaProductos[index].Precio = Convert.ToDouble(txtPrecio.Text);
                listaProductos[index].Cantidad = Convert.ToInt32(txtCantidad.Text);

                dgvProductos.DataSource = null;
                dgvProductos.DataSource = listaProductos;

                MessageBox.Show("Producto actualizado");
            }
        }
    }
    }
    
    


