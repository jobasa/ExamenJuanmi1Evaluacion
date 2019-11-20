using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class usuario
    {
        public usuario(string dni, string nombre, string apellido, int edad, string email)
        {
            Dni = dni;
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Email = email;
        }

        public string Dni { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Edad { get; set; }
        public string Email { get; set; }
    }
}