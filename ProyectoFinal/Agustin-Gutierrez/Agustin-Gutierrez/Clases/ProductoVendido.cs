using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agustin_Gutierrez.Clases
{
    public class ProductoVendido
    {
        //sin getter and setter

        private int _id;
        private int _idProducto;
        private int _stock;
        private int _idVenta;

        public ProductoVendido(int id, int idProducto, int stock, int idVenta)
        {
            _id = id;
            _idProducto = idProducto;
            _stock = stock;
            _idVenta = idVenta;
        }

        //Métodos para obtener y editar los valores

        public int ObtenerId()
        {
            return _id;
        }

        public int ObtenerIdProducto()
        {
            return _idProducto;
        }

        public int ObtenerStock()
        {
            return _stock;
        }

        public int ObtenerIdVenta()
        {
            return _idVenta;
        }
    }
}