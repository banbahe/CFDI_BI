using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CFDI.Controllers;
using CFDI;
using Newtonsoft.Json;
using System.Threading.Tasks;
namespace Services.Controllers
{
    public class CFDIController : ApiController
    {
        private CFDI.Controllers.ICFDI _cfdi;

        // GET: api/CFDI
        //public IEnumerable<string> Get()
        public async Task<IEnumerable<Models.CFDI>> Get()
        {
            _cfdi = new CFDI.Controllers.CFDIController();
            var result = await Task.Factory.StartNew(() => _cfdi.List());
            return result;
        }



        // GET: api/CFDI/5
        //[Route("{uuid:guid}")]
        public async Task<Models.CFDI> Get(int id)
        {
            _cfdi = new CFDI.Controllers.CFDIController();

            //var result = await Task.Factory.StartNew(() => _cfdi.Get(uuid));
            var result = await _cfdi.Get(id);
            return result;
        }

        // POST: api/CFDI
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/CFDI/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/CFDI/5
        public void Delete(int id)
        {
        }
    }
}
