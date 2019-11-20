using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class cuentaController : ApiController
    {
        // GET: api/cuenta
        public IEnumerable<cuenta> Get()
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new cuentaRepository();
            List<cuenta> cuentas= repo.Retrieve();
            return cuentas;
        }

        // GET: api/cuenta/5
        public cuenta Get(int id)
        {
            /*var repo = new cuentaRepository();
            cuenta c = repo.Retrieve();*/
            return null;
        }

        // POST: api/cuenta
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/cuenta/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/cuenta/5
        public void Delete(int id)
        {
        }
    }
}
