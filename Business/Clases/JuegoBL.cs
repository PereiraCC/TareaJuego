using BusinessLogic.Interfaces;
using DataAccess.Interfaces;
using Models.General;
using Models.Juego;
using Models.TipoJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic.Clases
{
    public class JuegoBL : IJuegoBL
    {
        private readonly IJuegoDA _Juego;

        public JuegoBL(IJuegoDA Juego)
        {
            _Juego = Juego;
        }

        public ResponseGeneric<List<Juego>> addValue(Juego juego)
        {
            return _Juego.addValue(juego);
        }

        public ResponseGeneric<List<Juego>> deleteValue(int idJuego)
        {
            return _Juego.deleteValue(idJuego);
        }

        public ResponseGeneric<List<Juego>> editValue(Juego juego, int idJuego)
        {
            return _Juego.editValue(juego, idJuego);
        }

        public ResponseGeneric<List<Juego>> getAll()
        {
            return _Juego.getAll();
        }

        public ResponseGeneric<List<Juego>> searchValue(string valor, EnumSearchJuego tipo)
        {
            return _Juego.searchValue(valor, tipo);
        }
    }
}
