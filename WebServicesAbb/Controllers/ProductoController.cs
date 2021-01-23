using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using ABB.Catalogo.Entidades.Core;
using ABB.Catalogo.LogicaNegocio.Core;


namespace WebServicesAbb.Controllers
{
    [Authorize]
    public class ProductoController: ApiController
    {
        [HttpGet]
        public IEnumerable<Producto> Get()
        {
            List<Producto> catalogo = new List<Producto>();
            catalogo = new ProductoLN().ListarProductos();

            return catalogo;
        }

        // GET: api/Productos/5
        public IHttpActionResult Get([FromUri] int idProducto)
        {
            if (idProducto <= 0)
            {
                return BadRequest("el Id debe ser mayor que 0");
            }

            try
            {
                Producto producto = new Producto();
                ProductoLN productoLN = new ProductoLN();
                producto = productoLN.BuscarProductoId(idProducto);
                return Ok(producto);
            }
            catch (Exception ex)
            {
                string innerException = (ex.InnerException == null) ? "" : ex.InnerException.ToString();
                //Logger.paginaNombre = this.GetType().Name;
                //Logger.Escribir("Error en Logica de Negocio: " + ex.Message + ". " + ex.StackTrace + ". " + innerException);
                throw;
            }
        }

        // POST: api/Productos
        public void Post([FromBody] string value)
        {
        }

        // PUT: api/Productos/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/Productos/5
        public void Delete(int id)
        {
        }

    }
}