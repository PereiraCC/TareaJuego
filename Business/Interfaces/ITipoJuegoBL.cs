using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Interfaces
{
    public interface ITipoJuegoBL
    {
        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> addValue(Models.TipoJuego.TipoJuego tipoJuego);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> editValue(Models.TipoJuego.TipoJuego tipoJuego, int idTipoJuego);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> searchValue(string valor);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> deleteValue(int idTipoJuego);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> getAll();
    }
}
