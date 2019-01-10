using AppMundialista.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AppMundialista.Controllers
{
    public class MundialController : Controller
    {
        // GET: Mundial
        public ActionResult Detalle(int IdEquipo)
        {
            var listado = ConsultarEquipos();
            var equipo = listado.FirstOrDefault(x => x.IdEquipo == IdEquipo);
            return View(equipo);

        }

        public ActionResult Equipos()
        {
            var listado = ConsultarEquipos();            
            return View(listado);
        }

        private List<Equipos> ConsultarEquipos()
        {
            var listaEquipos = new List<Equipos>();
            var listaJugadores = new List<Jugador>();
            for (int i = 0; i < 10; i++)
            {
                listaJugadores.Add(new Jugador
                {
                    Nombre = "Jugador " + i.ToString(),
                    Imagen = "Jugador1.png",
                    Posicion = i % 2 == 0 ? "Delantero" : "Defensa"
                });
            }

            listaEquipos.Add(new Equipos
            {
                IdEquipo=1,
                Nombre = "Colombia",
                Imagen = "Colombia.png",
                Jugadores = listaJugadores
            });

            listaEquipos.Add(new Equipos
            {
                IdEquipo = 2,
                Nombre = "Brazil",
                Imagen = "Brazil.png",
                Jugadores = listaJugadores
            });

            listaEquipos.Add(new Equipos
            {
                IdEquipo = 3,
                Nombre = "Holanda",
                Imagen = "Holanda.jpg",
                Jugadores = listaJugadores
            });


            return listaEquipos;
        }
    }
}