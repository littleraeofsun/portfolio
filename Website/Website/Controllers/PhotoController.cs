using Rae.Website.Models.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Rae.Website.Controllers
{
    public class PhotoController : ApiController
    {
        PhotoRepository photos = new PhotoRepository();

        [HttpGet()]
        [Route("api/Photo/GetAllPhotos")]
        public HttpResponseMessage GetAllPhotos()
        {
            return Request.CreateResponse(HttpStatusCode.OK, photos.GetAll());
        }

        [HttpGet()]
        [Route("api/Photo/GetAlbumPhotos/{AlbumId}")]
        public HttpResponseMessage GetAlbumPhotos(int AlbumId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, photos.GetAlbumPhotos(AlbumId));
        }
    }
}
