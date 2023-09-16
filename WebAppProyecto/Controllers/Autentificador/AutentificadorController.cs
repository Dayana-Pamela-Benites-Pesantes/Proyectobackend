using System;
using System.Collections.Generic;
using WebAppProyecto.Models.Clases.Auth;
using WebAppProyecto.Models.Clases.Response;
using WebAppProyecto.Models.Gestores.GestorAuth;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
//using WebAppProyecto.Models.Gestor;

namespace WebAppProyecto.Controllers.Autentificador
{
    public class AutentificadorController : ApiController
    {
        // GET: api/Autentificador
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET: api/Autentificador/5
        public string Get(int id)
        {
            return "value";
        }

        // POST: api/Autentificador
        public Response Post([FromBody]Auth auth)
        {
            GestorAuth gestorAuth = new GestorAuth();
            Response res = gestorAuth.GetResponse(auth.usuario, auth.password);
            return res;
        }

        // PUT: api/Autentificador/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/Autentificador/5
        public void Delete(int id)
        {
        }
    }
}
