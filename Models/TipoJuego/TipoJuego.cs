using Models.TipoJuego.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.TipoJuego
{
    public class TipoJuego : ITipoJuego
    {
        public int idTipoJuego { get; set; }

        public string descripcion { get; set; }
    }
}
