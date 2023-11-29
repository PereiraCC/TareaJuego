using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.General
{
    public static class GlobalVariables
    {
        public static List<Models.TipoJuego.TipoJuego> TipoJuegos { get; set; }

        public static List<Models.TipoJuego.TipoJuego> TipoJuegosFiltrados { get; set; }

        public static List<Models.Juego.Juego> Juegos { get; set; }

        public static List<Models.Juego.Juego> JuegosFiltrados { get; set; }

    }
}
