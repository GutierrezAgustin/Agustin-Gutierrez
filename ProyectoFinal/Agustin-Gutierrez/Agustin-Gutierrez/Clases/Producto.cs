using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agustin_Gutierrez.Clases
{
    public class Producto
    {
        //sin getter and setter

        private int _id;
        private string _descripción;
        private decimal _costo;
        private decimal _precioVenta;
        private int _stock;
        private int _idUsuario;

        public Producto(int id, string descripción, decimal costo, decimal precioVenta, int stock, int idUsuario)
        {
            _id = id;
            _descripción = descripción;
            _costo = costo;
            _precioVenta = precioVenta;
            _stock = stock;
            _idUsuario = idUsuario;
        }

        //Métodos para obtener y editar los valores

        public int ObtenerId()
        {
            return _id;
        }

        public string ObtenerDescripción()
        {
            return _descripción;
        }

        public decimal ObtenerCosto()
        {
            return _costo;
        }

        public decimal ObtenerPrecioVenta()
        {
            return _precioVenta;
        }

        public int ObtenerStock()
        {
            return _stock;
        }

        public int ObtenerIdUsuario()
        {
            return _idUsuario;
        }

        public void ActualizarStock(int nuevoStock)
        {
            _stock = nuevoStock;
        }
    }

}
