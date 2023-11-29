using Models.Juego.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Juego
{
    public class Juego : IJuego
    {
        public int idJuego { get; set; }
        public int idTipoJuego { get; set; }
        public string serialNumber { get; set; }
        public string year { get; set; }
        public string casaFabricante { get; set; }
    }
}
