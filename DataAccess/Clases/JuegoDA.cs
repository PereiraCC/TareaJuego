using DataAccess.Interfaces;
using Models.General;
using Models.Juego;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Clases
{
    public class JuegoDA : IJuegoDA
    {
        public ResponseGeneric<List<Juego>> addValue(Juego juego)
        {
            try
            {
                // Se agrega el nuevo Juego
                GlobalVariables.Juegos.Add(juego);

                return new ResponseGeneric<List<Juego>>(GlobalVariables.Juegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        public ResponseGeneric<List<Juego>> editValue(Juego juego, int idJuego)
        {
            try
            {
                // Se busca el index de juego a modificar
                int indexJuego = GlobalVariables.Juegos.FindIndex(juego => juego.idJuego == idJuego);

                // Se valida que index sea correcto
                if (indexJuego != -1)
                {
                    // Se modifica el objeto
                    GlobalVariables.Juegos[indexJuego].idTipoJuego = juego.idTipoJuego;
                    GlobalVariables.Juegos[indexJuego].serialNumber = juego.serialNumber;
                    GlobalVariables.Juegos[indexJuego].year = juego.year;
                    GlobalVariables.Juegos[indexJuego].casaFabricante = juego.casaFabricante;
                }

                return new ResponseGeneric<List<Juego>>(GlobalVariables.Juegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        public ResponseGeneric<List<Juego>> deleteValue(int idJuego)
        {
            try
            {
                // Se busca el index de juego a eliminar
                int indexJuego = GlobalVariables.Juegos.FindIndex(juego => juego.idJuego == idJuego);

                if (indexJuego == -1)
                {
                    return new ResponseGeneric<List<Juego>>("No se encontro el Juego");
                }

                // Se eliminar el tipo juego
                Models.General.GlobalVariables.Juegos.RemoveAt(indexJuego);

                return new ResponseGeneric<List<Juego>>(GlobalVariables.Juegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        public ResponseGeneric<List<Juego>> searchValue(string valor, EnumSearchJuego tipo)
        {
            try
            {
                switch (tipo)
                {
                    case EnumSearchJuego.TipoJuego:
                        GlobalVariables.JuegosFiltrados = GlobalVariables.Juegos.Where(juego => juego.idTipoJuego == Int32.Parse(valor)).ToList();
                        break;

                    case EnumSearchJuego.Year:
                        GlobalVariables.JuegosFiltrados = GlobalVariables.Juegos.Where(juego => juego.year.Equals(valor)).ToList();
                        break;

                    case EnumSearchJuego.CasaFabricante:
                        GlobalVariables.JuegosFiltrados = GlobalVariables.Juegos.Where(juego => juego.casaFabricante.ToLower().Contains(valor.ToLower())).ToList();
                        break;
                }

                return new ResponseGeneric<List<Juego>>(GlobalVariables.JuegosFiltrados);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        public ResponseGeneric<List<Juego>> getAll()
        {
            try
            {
                return new ResponseGeneric<List<Juego>>(GlobalVariables.Juegos);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }
        
    }
}
