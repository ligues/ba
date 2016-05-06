using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Mvc;

namespace bydsa_atencion.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<Usuario> Get()
        {
            //return new string[] { "value1", "value2" };

            dataDataContext db = new dataDataContext();

            usuario o_usuario = new usuario();
            var usuarios = (from p in db.usuarios select p).ToList();

            return usuarios;

        }

        // GET api/values/5
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        public void Delete(int id)
        {
        }
    }
}
