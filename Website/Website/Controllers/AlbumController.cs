using Rae.Website.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rae.Website.Controllers
{
    public class AlbumController : ApiController
    {
        AlbumRepository repository = new AlbumRepository();
        
        [HttpGet()]
        [Route("api/Albums")]
        public HttpResponseMessage GetAllAlbums()
        {
            return Request.CreateResponse(HttpStatusCode.OK, repository.GetAll());
        }

        [HttpGet()]
        [Route("api/Albums/{id}")]
        public HttpResponseMessage GetAlbumById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, repository.Get(id));
        }

        [HttpGet()]
        [Route("api/Albums/{title}")]
        public HttpResponseMessage GetAlbumByTitle(string title)
        {
            return Request.CreateResponse(HttpStatusCode.OK, repository.GetByName(title));
        }
    }
}
