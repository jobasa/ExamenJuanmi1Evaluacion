using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class usuarioController : ApiController
    {
        // GET: api/usuario
        public IEnumerable<usuario> Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new usuarioRepository();
            List<usuario> usuarios= repo.Retrieve();
            return usuarios;
        }

        // GET: api/usuario/5
        public usuario Get(int id)
        {
            /*var repo = new usuarioRepository();
            usuario u = repo.Retrieve();*/
            return null;
        }

        // POST: api/usuario
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/usuario/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/usuario/5
        public void Delete(int id)
        {
        }
    }
}
