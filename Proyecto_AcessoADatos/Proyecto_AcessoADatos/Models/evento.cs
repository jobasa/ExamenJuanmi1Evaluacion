using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_AcessoADatos.Models
{
    public class evento
    {
        public evento(int ID_Equipo, string Equipo_Local, string Equipo_visitante)
        {
            this.ID_Equipo = ID_Equipo;
            this.Equipo_Local = Equipo_Local;
            this.Equipo_visitante = Equipo_visitante;
        }

        public int ID_Equipo { get; set; }
        public string Equipo_Local { get; set; }
        public string Equipo_visitante { get; set; }
    }

    public class eventoDTO
    {
        public eventoDTO(string Equipo_Local, string Equipo_visitante)
        {
            this.Equipo_Local = Equipo_Local;
            this.Equipo_visitante = Equipo_visitante;
        }

        public string Equipo_Local { get; set; }
        public string Equipo_visitante { get; set; }
    }
}