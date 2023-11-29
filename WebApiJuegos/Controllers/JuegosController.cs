using Microsoft.AspNetCore.Mvc;
using Models.General;
using Models.Juego;

namespace WebApiJuegos.Controllers
{
    [ApiController]
    public class JuegosController : Controller
    {
        public BusinessLogic.Interfaces.IJuegoBL _juegoBL;

        public JuegosController(BusinessLogic.Interfaces.IJuegoBL juegoBL)
        {
            this._juegoBL = juegoBL;
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<Juego>> Create([FromBody] Juego juego)
        {
            try
            {
                return _juegoBL.addValue(juego);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<Juego>> Edit([FromBody] Juego juego)
        {
            try
            {
                return _juegoBL.editValue(juego, juego.idJuego);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<Juego>> Search(string valor, string tipo)
        {
            try
            {
                EnumSearchJuego enumSearchJuego = EnumSearchJuego.TipoJuego;
                switch (tipo)
                {
                    case "1":
                        enumSearchJuego = EnumSearchJuego.TipoJuego;
                        break;

                    case "2":
                        enumSearchJuego = EnumSearchJuego.Year;
                        break;

                    case "3":
                        enumSearchJuego = EnumSearchJuego.CasaFabricante;
                        break;
                }
                return _juegoBL.searchValue(valor, enumSearchJuego);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<Juego>> Delete(int idJuego)
        {
            try
            {
                return _juegoBL.deleteValue(idJuego);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<Juego>> GetAll()
        {
            try
            {
                return _juegoBL.getAll();
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<Juego>>(ex);
            }
        }
    }
}
