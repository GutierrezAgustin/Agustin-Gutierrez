using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agustin_Gutierrez.Clases
{
    public class Venta
    {
        //sin getter and setter

        private int _id;
        private string _comentarios;
        private int _idUsuario;
        private string _fechaVenta;

        public Venta(int id, string comentarios, int idUsuario, string fechaVenta)
        {
            _id = id;
            _comentarios = comentarios;
            _idUsuario = idUsuario;
            _fechaVenta = fechaVenta;
        }

        //Métodos para obtener y editar los valores

        public int ObtenerId()
        {
            return _id;
        }

        public string ObtenerComentarios()
        {
            return _comentarios;
        }

        public int ObtenerIdUsuario()
        {
            return _idUsuario;
        }

        public string ObtenerFechaVenta()
        {
            return _fechaVenta;
        }
    }
}
