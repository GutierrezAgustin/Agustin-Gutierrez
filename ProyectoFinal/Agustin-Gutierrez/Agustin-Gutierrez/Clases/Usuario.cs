using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agustin_Gutierrez.Clases
{
    public class Usuario
    {
        //sin getter and setter

        private int _id;
        private string _nombre;
        private string _apellido;
        private string _nombreUsuario;
        private string _contraseña;
        private string _mail;
        private string _posicion;
        private string _fechaAlta;

        public Usuario(int id, string nombre, string apellido, string nombreUsuario, string contraseña, string mail, string posicion ,string fechaAlta)
        {
            _id = id;
            _nombre = nombre;
            _apellido = apellido;
            _nombreUsuario = nombreUsuario;
            _contraseña = contraseña;
            _mail = mail;
            _posicion = posicion;
            _fechaAlta = fechaAlta;
        }

        //Métodos para obtener y editar los valores

        public int ObtenerId()
        {
            return _id;
        }

        public string ObtenerNombre()
        {
            return _nombre;
        }

        public string ObtenerApellido()
        {
            return _apellido;
        }

        public string ObtenerNombreUsuario()
        {
            return _nombreUsuario;
        }

        public string ObtenerContraseña()
        {
            return _contraseña;
        }

        public string ObtenerMail()
        {
            return _mail;
        }

        public string ObtenerPosicion()
        {
            return _posicion;
        }

        public string ObtenerFechaAlta()
        {
            return _fechaAlta;
        }

    }
}
