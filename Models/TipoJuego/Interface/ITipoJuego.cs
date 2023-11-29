using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.TipoJuego.Interface
{
    public interface ITipoJuego
    {
        int idTipoJuego { get; set; }

        string descripcion { get; set; }
    }
}
