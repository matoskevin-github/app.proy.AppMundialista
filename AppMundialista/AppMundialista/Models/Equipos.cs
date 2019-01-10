using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace AppMundialista.Models
{
    public class Equipos
    {
        public int IdEquipo { get; set; }
        public string Nombre { get; set; }
        public string Imagen { get; set; }
        public List<Jugador> Jugadores { get; set; }
    }
}