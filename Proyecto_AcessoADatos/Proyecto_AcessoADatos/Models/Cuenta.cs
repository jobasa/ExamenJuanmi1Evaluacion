using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class cuenta
    {
        public cuenta(string dni, int saldo_actual, string nombre_banco, int num_tarjeta_vinculada)
        {
            Dni = dni;
            Saldo_actual = saldo_actual;
            Nombre_banco = nombre_banco;
            Num_tarjeta_vinculada = num_tarjeta_vinculada;
        }

        public string Dni { get; set; }
        public int Saldo_actual { get; set; }
        public string Nombre_banco { get; set; }
        public int Num_tarjeta_vinculada { get; set; }
    }
}