using Models.Juego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Interfaces
{
    public interface IJuegoDA
    {
        Models.General.ResponseGeneric<List<Models.Juego.Juego>> addValue(Models.Juego.Juego juego);

        Models.General.ResponseGeneric<List<Models.Juego.Juego>> editValue(Models.Juego.Juego juego, int idJuego);

        Models.General.ResponseGeneric<List<Models.Juego.Juego>> searchValue(string valor, EnumSearchJuego tipo);

        Models.General.ResponseGeneric<List<Models.Juego.Juego>> deleteValue(int idJuego);

        Models.General.ResponseGeneric<List<Models.Juego.Juego>> getAll();
    }
}
