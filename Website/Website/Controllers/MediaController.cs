﻿using Rae.Website.Models;
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

        [HttpGet()]
        [Route("api/Media/ByProject/{id}")]
        public HttpResponseMessage GetMediaByProject(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetByProject(id));
        }

        [HttpGet()]
        [Route("api/Media/ByAlbum/{id}")]
        public HttpResponseMessage GetMediaByAlbum(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetByAlbum(id));
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

        [HttpGet()]
        [Route("api/Images/ByProject/{id}")]
        public HttpResponseMessage GetImagesByProject(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.GetByProject(id));
        }

        [HttpGet()]
        [Route("api/Images/ByAlbum/{id}")]
        public HttpResponseMessage GetImagesByAlbum(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.GetByAlbum(id));
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

        [HttpGet()]
        [Route("api/Audio/ByProject/{id}")]
        public HttpResponseMessage GetAudioByProject(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, audio.GetByProject(id));
        }

        [HttpGet()]
        [Route("api/Audio/ByAlbum/{id}")]
        public HttpResponseMessage GetAudioByAlbum(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, audio.GetByAlbum(id));
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

        [HttpGet()]
        [Route("api/Video/ByProject/{id}")]
        public HttpResponseMessage GetVideoByProject(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, video.GetByProject(id));
        }

        [HttpGet()]
        [Route("api/Video/ByAlbum/{id}")]
        public HttpResponseMessage GetVideoByAlbum(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, video.GetByAlbum(id));
        }
        #endregion
    }
}
