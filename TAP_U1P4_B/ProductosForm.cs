using Microsoft.VisualBasic.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TAP_U1P4_B.clases;

namespace TAP_U1P4_B
{
    public partial class ProductosForm : Form
    {
        private String rutaImagen = null;
        private Producto productoSel = null;
        private List<Producto> lista = new List<Producto>();

        public ProductosForm()
        {
            InitializeComponent();
        }

        private void btnExaminar_Click(object sender, EventArgs e)
        {
            if(openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                rutaImagen = openFileDialog1.FileName;
                imgBox.Load(rutaImagen);
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelCantidad.Text = "" + quantity.Value;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            productName.Text = productName.Text.ToUpper();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            rutaImagen = null;

            productName.Clear();
            imgBox.Image = null;
            productPrice.Value = 0;
            quantity.Value = 0;
            labelCantidad.Text = "0";
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool esNuevo = true;
            if (selectBox.SelectedIndex >= 0)
            {
                productoSel = lista[selectBox.SelectedIndex];
            }
            try
            {
                Producto p = new Producto();
                if(productoSel != null)
                {
                    p = productoSel;
                    esNuevo = false;
                }
                p.Nombre = productName.Text;
                p.Cantidad = quantity.Value;
                p.Precio = Double.Parse("" + productPrice.Value);
                

                if(esNuevo)
                {
                    lista.Add(p);
                    p.Imagen = rutaImagen;
                }
                else
                {
                    if(rutaImagen != null)
                    {
                        p.Imagen = rutaImagen;
                    }
                    lista[selectBox.SelectedIndex] = p;
                }

                // Convertir la lista a JSON
                String json = JsonConvert.SerializeObject(lista);

                StreamWriter sw = new StreamWriter(
                    "productos.json", false
                );
                sw.Write(json);
                sw.Close();

                MessageBox.Show("Guardado");
                btnLimpiar_Click(sender, e);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                new Log().WriteException(ex);
                MessageBox.Show("Error");
            }
        }

        private void ProductosForm_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("productos.json");
                String json = sr.ReadToEnd();
                sr.Close();

                // Se convierte el JSON a lista de Producto
                lista = JsonConvert.DeserializeObject<List<Producto>>(json);

                cargar();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                new Log().WriteException(ex);
            }
        }

        private void cargar()
        {
            selectBox.Items.Clear();
            foreach (Producto p in lista)
            {
                selectBox.Items.Add(p.Nombre);
            }
            selectBox.SelectedIndex = -1;
            selectBox.Enabled = lista.Count > 0;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (selectBox.SelectedIndex >= 0)
            {
                int idProducto = selectBox.SelectedIndex;
                Producto p = lista[idProducto];
                productName.Text = p.Nombre;
                quantity.Value = p.Cantidad;
                productPrice.Value = (decimal)p.Precio;
                labelCantidad.Text = "" + p.Cantidad;
                try
                {
                    imgBox.Load(p.Imagen);
                }
                catch (Exception exception)
                {
                    Console.WriteLine(exception.Message);
                }
                
                
                
            }
            

            // Cargar los datos del producto seleccionado
        }
    }
}
