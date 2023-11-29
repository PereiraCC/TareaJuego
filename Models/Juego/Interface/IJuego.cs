using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Juego.Interface
{
    public interface IJuego
    {
        int idJuego { get; set; }

        int idTipoJuego { get; set; }

        string serialNumber { get; set; }

        string year { get; set; }

        string casaFabricante { get; set; }

    }
}
