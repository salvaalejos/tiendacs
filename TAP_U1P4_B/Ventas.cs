using System;
using System.Windows.Forms;
using TAP_U1P4_B.clases;
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

namespace TAP_U1P4_B
{
    public partial class Ventas : Form
    {
        private Producto productoSel = null;
        private List<Producto> lista = new List<Producto>();
        private List<Venta> listaVentas = new List<Venta>();
        
        public Ventas()
        {
            InitializeComponent();
            gridVentas.Columns.Add("Nombre", "Nombre");
            gridVentas.Columns.Add("Cantidad", "Cantidad");
            gridVentas.Columns.Add("Total", "Total");
            gridVentas.Columns.Add("Fecha", "Fecha");
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("productos.json");
                String json = sr.ReadToEnd();
                sr.Close();
                lista = JsonConvert.DeserializeObject<List<Producto>>(json);
                try
                {
                    StreamReader sr2 = new StreamReader("ventas.json");
                    String json2 = sr2.ReadToEnd();
                    sr2.Close();
                    listaVentas = JsonConvert.DeserializeObject<List<Venta>>(json2);
                }
                catch (Exception exception)
                {
                    Console.WriteLine("No hay ventas registradas: "+exception.Message);
                }
                
                limpiar();
                cargar();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("No hay productos registrados");
                
            }
            
        }

        private void cargar()
        {
            // Cargar productos
            productToSell.Items.Clear();
            totalSales.Items.Clear();
            foreach (Producto p in lista)
            {
                productToSell.Items.Add(p.Nombre);
                totalSales.Items.Add(p.Nombre);
            }
            totalSales.Items.Add("TOTAL");
            productToSell.SelectedIndex = -1;
            productToSell.Enabled = lista.Count > 0;
            // Cargar ventas
            gridVentas.Rows.Clear();
            
            foreach (Venta v in listaVentas)
            {
                string totalFormatted = "$ " + v.Total.ToString("F2");
                gridVentas.Rows.Add(v.Nombre, v.Cantidad, totalFormatted, v.Fecha);
            }
            
        }

        private void limpiar()
        {
            productToSell.SelectedIndex = -1;
            productName.Text = "";
            price.Text = "";
            quantityToSell.Maximum = 0;
            quantityToSell.Minimum = 0;
            quantityToSell.Value = 0;
            quantityToSell.Enabled = false;
            lblTotal.Text = "$ 0";
            imgBox.Image = null;
        }

        private void vender()
        {
            int idProduct = productToSell.SelectedIndex;
            int cantidad = (int)quantityToSell.Value;
            if (cantidad <= 0)
            {
                MessageBox.Show("Lo sentimos, producto agotado");
                return;
            }
            Producto p = lista[idProduct];
            p.Cantidad -= cantidad;
            lista[idProduct] = p;
            Venta v = new Venta(p, cantidad, DateTime.Now.ToString("MM/dd/yyyy"));
            listaVentas.Add(v);
            String json = JsonConvert.SerializeObject(listaVentas);
            StreamWriter sw = new StreamWriter("ventas.json", false);
            sw.Write(json);
            sw.Close();
            String json2 = JsonConvert.SerializeObject(lista);
            StreamWriter sw2 = new StreamWriter("productos.json", false);
            sw2.Write(json2);
            sw2.Close();
            MessageBox.Show("Venta realizada");
            limpiar();
            cargar();
        }

        private void productToSell_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (productToSell.SelectedIndex >= 0)
                {
                
                    int idProduct = productToSell.SelectedIndex;
                    Producto p = lista[idProduct];
                    productName.Text = p.Nombre;
                    price.Text = "$ "+p.Precio;
                    if (p.Cantidad <= 0)
                    {
                        quantityToSell.Value = 0;
                        quantityToSell.Enabled = false;
                        quantityToSell.Maximum = 0;
                        quantityToSell.Minimum = 0;
                    }
                    else
                    {
                        quantityToSell.Enabled = true;
                        quantityToSell.Maximum = p.Cantidad;
                        quantityToSell.Minimum = 1;
                        quantityToSell.Value = 1;
                    }
                
                    Double total = p.Precio * (double)quantityToSell.Value;
                    lblTotal.Text = "$ "+total;
                    if (p.Imagen != null)
                    {
                        imgBox.Load(p.Imagen);
                    }
                
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                MessageBox.Show("Error");
            }
            
        }

        private void quantityToSell_ValueChanged(object sender, EventArgs e)
        {
            if (productToSell.SelectedIndex >= 0)
            {
                int idProduct = productToSell.SelectedIndex;
                Producto p = lista[idProduct];
                Double total = p.Precio * (double)quantityToSell.Value;
                lblTotal.Text = "$ "+total;
            }
        }

        private void btnCancelSale_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void btnConfirmSale_Click(object sender, EventArgs e)
        {
            if (productToSell.SelectedIndex >= 0)
            {
                vender();
            }
        }


        private void totalSales_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                
                Double total = 0;
                int cantidad = 0;
                if(listaVentas.Count > 0)
                {
                    
                    
                    if(totalSales.SelectedIndex == lista.Count)
                    {
                        foreach (Venta v in listaVentas)
                        {
                            total += v.Total;
                            cantidad += v.Cantidad;
                        }
                    } else
                    {
                        int idProducto = totalSales.SelectedIndex;
                        Producto p = lista[idProducto];
                        foreach (Venta v in listaVentas)
                        {
                            if (v.Nombre == p.Nombre)
                            {
                                cantidad += v.Cantidad;
                                total += v.Total;
                            }
                        }
                    }
                    totalSale.Text = "$ "+total;
                    totalQuantitySelled.Text = cantidad.ToString();
                    
                }
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception);
                throw;
            }
        }

        
    }
}





