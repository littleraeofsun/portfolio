using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rae.Website.Controllers
{
    public class PortfolioController : ApiController
    {
        [HttpPost()]
        [Route("api/email")]
        public HttpResponseMessage GetContactEmail()
        {
            return Request.CreateResponse(HttpStatusCode.OK, "rae@littleraeofsun.com");
        }
    }
}
