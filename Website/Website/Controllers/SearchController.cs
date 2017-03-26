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
    public class SearchController : ApiController
    {
        ProjectRepository projects = new ProjectRepository();
        AlbumRepository albums = new AlbumRepository();
        MediaRepository<Media> media = new MediaRepository<Media>();
        ImageRepository images = new ImageRepository();
        AudioRepository audio = new AudioRepository();
        VideoRepository video = new VideoRepository();


        [HttpGet()]
        [Route("api/Search/{term}")]
        public HttpResponseMessage SearchAllContent(string term)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        [HttpGet()]
        [Route("api/Search/Projects/{term}")]
        public HttpResponseMessage SearchProjects(string term)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        [HttpGet()]
        [Route("api/Search/Albums/{term}")]
        public HttpResponseMessage SearchAlbums(string term)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        [HttpGet()]
        [Route("api/Search/Media/{term}")]
        public HttpResponseMessage SearchMedia(string term)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        [HttpGet()]
        [Route("api/Search/Images/{term}")]
        public HttpResponseMessage SearchImages(string term)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        [HttpGet()]
        [Route("api/Search/Audio/{term}")]
        public HttpResponseMessage SearchAudio(string term)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }

        [HttpGet()]
        [Route("api/Search/Video/{term}")]
        public HttpResponseMessage SearchVideo(string term)
        {
            return Request.CreateResponse(HttpStatusCode.NotImplemented);
        }
    }
}
