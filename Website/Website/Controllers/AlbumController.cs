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
    public class AlbumController : ApiController
    {
        AlbumRepository repository = new AlbumRepository();
        MediaRepository<Media> media = new MediaRepository<Media>();
        ImageRepository images = new ImageRepository();
        AudioRepository audio = new AudioRepository();
        VideoRepository video = new VideoRepository();

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
        [Route("api/Albums/{id}/Media")]
        public HttpResponseMessage GetAlbumMedia(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetByAlbum(id));
        }

        [HttpGet()]
        [Route("api/Albums/{id}/Images")]
        public HttpResponseMessage GetAlbumImages(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.GetByAlbum(id));
        }

        [HttpGet()]
        [Route("api/Albums/{id}/Audio")]
        public HttpResponseMessage GetAlbumAudio(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, audio.GetByAlbum(id));
        }

        [HttpGet()]
        [Route("api/Albums/{id}/Video")]
        public HttpResponseMessage GetAlbumVideo(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, video.GetByAlbum(id));
        }
    }
}
