using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TAP_U1P4_B.clases
{
    public class Producto
    {
        public Producto()
        {
        }

        private String nombre;

        public String Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }


        private int cantidad;

        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }

        private Double precio;

        public Double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        private String imagen;

        public String Imagen
        {
            get { return imagen; }
            set { imagen = value; }
        }


        public Producto(String nombre, int cantidad, Double precio, String imagen)
        {
            this.nombre = nombre;
            this.cantidad = cantidad;
            this.precio = precio;
            this.imagen = imagen;
        }

    }
}
