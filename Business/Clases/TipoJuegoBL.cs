using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Models.General;
using Models.TipoJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Clases
{
    public class TipoJuegoBL : ITipoJuegoBL
    {
        private readonly ITipoJuegoDA _TipoJuego;

        public TipoJuegoBL(ITipoJuegoDA TipoJuego)
        {
            _TipoJuego = TipoJuego;
        }

        public ResponseGeneric<List<TipoJuego>> addValue(TipoJuego tipoJuego)
        {
            return _TipoJuego.addValue(tipoJuego);
        }

        public ResponseGeneric<List<TipoJuego>> deleteValue(int idTipoJuego)
        {
            return _TipoJuego.deleteValue(idTipoJuego);
        }

        public ResponseGeneric<List<TipoJuego>> editValue(TipoJuego tipoJuego, int idTipoJuego)
        {
            return _TipoJuego.editValue(tipoJuego, idTipoJuego);
        }

        public ResponseGeneric<List<TipoJuego>> getAll()
        {
            return _TipoJuego.getAll();
        }

        public ResponseGeneric<List<TipoJuego>> searchValue(string valor)
        {
            return _TipoJuego.searchValue(valor);
        }
    }
}
