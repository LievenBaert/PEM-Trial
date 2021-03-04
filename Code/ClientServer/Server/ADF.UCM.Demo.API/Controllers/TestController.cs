using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ADF.UCM.Demo.API.Controllers
{

    public class TestController : ApiController
    {
        [HttpGet]
        [Route("api/Response")]
        public IHttpActionResult GetResponse()
        {
            return Ok("Hello World!");
        }

    }
}
