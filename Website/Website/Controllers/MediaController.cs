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
        MediaRepository<Media> media = new MediaRepository<Media>();
        ImageRepository images = new ImageRepository();
        AudioRepository audio = new AudioRepository();
        VideoRepository video = new VideoRepository();

        #region Generic Actions
        [HttpGet()]
        [Route("api/Media")]
        public HttpResponseMessage GetAllMedia()
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetAll());
        }
        [HttpGet()]
        [Route("api/Media/{id}")]
        public HttpResponseMessage GetMediaById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.Get(id));
        }
        #endregion

        #region Image Actions
        [HttpGet()]
        [Route("api/Images")]
        public HttpResponseMessage GetAllImages()
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.GetAll());
        }
        [HttpGet()]
        [Route("api/Images/{id}")]
        public HttpResponseMessage GetImageById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.Get(id));
        }
        #endregion

        #region Audio Actions
        [HttpGet()]
        [Route("api/Audio")]
        public HttpResponseMessage GetAllAudio()
        {
            return Request.CreateResponse(HttpStatusCode.OK, audio.GetAll());
        }
        [HttpGet()]
        [Route("api/Audio/{id}")]
        public HttpResponseMessage GetAudioById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, audio.Get(id));
        }
        #endregion

        #region Video Actions
        [HttpGet()]
        [Route("api/Video")]
        public HttpResponseMessage GetAllVideo()
        {
            return Request.CreateResponse(HttpStatusCode.OK, video.GetAll());
        }
        [HttpGet()]
        [Route("api/Video/{id}")]
        public HttpResponseMessage GetVideoById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, video.Get(id));
        }
        #endregion
    }
}
