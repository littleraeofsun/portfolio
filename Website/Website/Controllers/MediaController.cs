using Rae.Website.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rae.Website.Controllers
{
    public class MediaController : ApiController
    {
        MediaRepository media = new MediaRepository();

        [HttpGet()]
        [Route("api/Media/GetAllMedia")]
        public HttpResponseMessage GetAllMedia()
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetAll());
        }

        [HttpGet()]
        [Route("api/Media/GetProjectMedia/{ProjectId}")]
        public HttpResponseMessage GetProjectMedia(int ProjectId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetProjectMedia(ProjectId));
        }
    }
}
