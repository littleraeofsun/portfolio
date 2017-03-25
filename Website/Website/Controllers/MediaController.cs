using Rae.Website.Models;
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

        #region Generic Actions
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

        [HttpGet()]
        [Route("api/Media/GetAlbumMedia/{AlbumId}")]
        public HttpResponseMessage GetAlbumMedia(int AlbumId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetAlbumMedia(AlbumId));
        }
        #endregion

        #region Image Actions
        [HttpGet()]
        [Route("api/Media/GetAllImages")]
        public HttpResponseMessage GetAllImages()
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetAllMediaOfType<Image>());
        }

        [HttpGet()]
        [Route("api/Media/GetProjectImages/{ProjectId}")]
        public HttpResponseMessage GetProjectImages(int ProjectId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetProjectMediaOfType<Image>(ProjectId));
        }

        [HttpGet()]
        [Route("api/Media/GetAlbumImages/{AlbumId}")]
        public HttpResponseMessage GetAlbumImages(int AlbumId)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetAlbumMediaOfType<Image>(AlbumId));
        }
        #endregion
    }
}
