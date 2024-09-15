using System;

namespace TAP_U1P4_B.clases
{
    public class Venta
    {
        
        private String nombre;
        private int cantidad;
        private Double total;
        private String fecha;

        public Venta()
        {
        }
        public Venta(Producto producto, int cantidad, String fecha)
        {
            this.nombre = producto.Nombre;
            this.cantidad = cantidad;
            this.total = producto.Precio * cantidad;
            this.fecha = fecha;
        }
        
        
        
        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        
        public Double Total
        {
            get { return total; }
            set { total = value; }
        }
        
        public String Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        
    }
}