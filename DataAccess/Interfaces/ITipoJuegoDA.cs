using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface ITipoJuegoDA
    {
        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> addValue(Models.TipoJuego.TipoJuego tipoJuego);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> editValue(Models.TipoJuego.TipoJuego tipoJuego, int idTipoJuego);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> searchValue(string valor);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> deleteValue(int idTipoJuego);

        Models.General.ResponseGeneric<List<Models.TipoJuego.TipoJuego>> getAll();
    }
}
