using Microsoft.AspNetCore.Mvc;
using Models.General;
using Models.TipoJuego;

namespace WebApiJuegos.Controllers
{
    [ApiController]
    public class TipoJuegosController : Controller
    {
        public BusinessLogic.Interfaces.ITipoJuegoBL _tipoJuegoBL;

        public TipoJuegosController(BusinessLogic.Interfaces.ITipoJuegoBL tipoJuegoBL)
        {
            this._tipoJuegoBL = tipoJuegoBL;
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<TipoJuego>> Create([FromBody] TipoJuego tipoJuego)
        {
            try
            {
                return _tipoJuegoBL.addValue(tipoJuego);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<TipoJuego>> Edit([FromBody] TipoJuego tipoJuego)
        {
            try
            {
                return _tipoJuegoBL.editValue(tipoJuego, tipoJuego.idTipoJuego);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<TipoJuego>> Search(string valor)
        {
            try
            {
                return _tipoJuegoBL.searchValue(valor);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<TipoJuego>> Delete(int idTipoJuego)
        {
            try
            {
                return _tipoJuegoBL.deleteValue(idTipoJuego);
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }

        [HttpPost]
        [Route("/api/[controller]/[action]")]
        public ResponseGeneric<List<TipoJuego>> GetAll()
        {
            try
            {
                return _tipoJuegoBL.getAll();
            }
            catch (Exception ex)
            {
                return new ResponseGeneric<List<TipoJuego>>(ex);
            }
        }
    }
}
