using Rae.Website.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rae.Website.Controllers
{
    public class ImageController : ApiController
    {
        ImageRepository images = new ImageRepository();

        [HttpGet()]
        [Route("api/Image/GetAllImages")]
        public HttpResponseMessage GetAllImages()
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.GetAll());
        }

        [HttpGet()]
        [Route("api/Image/GetProjectImages/{ProjectId}")]
        public HttpResponseMessage GetProjectImages(int ProjectId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.GetProjectImages(ProjectId));
        }
    }
}
