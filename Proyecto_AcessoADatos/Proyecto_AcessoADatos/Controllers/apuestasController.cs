using Proyecto_AcessoADatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Proyecto_AcessoADatos.Controllers
{
    public class apuestasController : ApiController
    {
        // GET: api/apuestas
        [Authorize]
        public apuestasDTO Get(string Email)
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new apuestasRepository();
            /*List<apuestas> apuesta = repo.Retrieve();*/
            apuestasDTO apuesta = repo.RetrieveDTO();
            return apuesta;
        }

        public apuestas GetApuestas(string Email)
        {
            //Devuelve un array de eventos en formato JSON
            var repo = new apuestasRepository();
            /*List<apuestas> apuesta = repo.Retrieve();*/
            apuestas apuesta = repo.Retrieve();
            return apuesta;
        }

        // GET: api/apuestas/5
        public List<apuestas> Get(int id)
        {
            var repo = new apuestasRepository();
            List<apuestas> a = repo.Retrieve();
            return a;
        }

        // POST: api/apuestas
        public void Post([FromBody]apuestas d)
        {
            var repo = new apuestasRepository();
            repo.Save(d);
        }

        // PUT: api/apuestas/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/apuestas/5
        public void Delete(int id)
        {
        }
    }
}
