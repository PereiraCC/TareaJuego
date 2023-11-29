using DataAccess.Interfaces;
using Models.General;
using Models.TipoJuego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases
{
    public class TipoJuegoDA : ITipoJuegoDA
    {
        public ResponseGeneric<List<TipoJuego>> addValue(TipoJuego tipoJuego)
        {
            try
            {
                // Se agrega el nuevo tipo Juego
                GlobalVariables.TipoJuegos.Add(tipoJuego);

                return new ResponseGeneric<List<TipoJuego>>(GlobalVariables.TipoJuegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        public ResponseGeneric<List<TipoJuego>> editValue(TipoJuego tipoJuego, int idTipoJuego)
        {
            try
            {
                // Se busca el index de tipo juego a modificar
                int indexTipoJuego = GlobalVariables.TipoJuegos.FindIndex(tipoJ => tipoJ.idTipoJuego == idTipoJuego);

                // Se valida que index sea correcto
                if (indexTipoJuego != -1)
                {
                    // Se modifica el objeto
                    GlobalVariables.TipoJuegos[indexTipoJuego].descripcion = tipoJuego.descripcion;
                }

                return new ResponseGeneric<List<TipoJuego>>(GlobalVariables.TipoJuegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        public ResponseGeneric<List<TipoJuego>> deleteValue(int idTipoJuego)
        {
            try
            {
                // Se busca el index de tipoJuego a eliminar
                int indexTipoJuego = GlobalVariables.TipoJuegos.FindIndex(tipoJ => tipoJ.idTipoJuego == idTipoJuego);

                if (indexTipoJuego == -1)
                {
                    return new ResponseGeneric<List<TipoJuego>>("No se encontro el Tipo Juego");
                }

                // Se eliminar el tipo juego
                Models.General.GlobalVariables.TipoJuegos.RemoveAt(indexTipoJuego);

                return new ResponseGeneric<List<TipoJuego>>(GlobalVariables.TipoJuegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        public ResponseGeneric<List<TipoJuego>> searchValue(string valor)
        {
            try
            {
                GlobalVariables.TipoJuegosFiltrados = GlobalVariables.TipoJuegos.Where(tipoJuego => tipoJuego.descripcion.Contains(valor)).ToList();

                return new ResponseGeneric<List<TipoJuego>>(GlobalVariables.TipoJuegosFiltrados);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        public ResponseGeneric<List<TipoJuego>> getAll()
        {
            try
            {
                return new ResponseGeneric<List<TipoJuego>>(GlobalVariables.TipoJuegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }
        
    }
}
