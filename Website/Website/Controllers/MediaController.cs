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
        [Route("api/Media/{type}")]
        public HttpResponseMessage GetAllMedia(string type)
        {
            HttpResponseMessage result = null;
            switch (type.ToLower())
            {
                case "all":
                    result = Request.CreateResponse(HttpStatusCode.OK, media.GetAll());
                    break;
                case "images":
                    result = Request.CreateResponse(HttpStatusCode.OK, images.GetAll());
                    break;
                case "audio":
                    result = Request.CreateResponse(HttpStatusCode.OK, audio.GetAll());
                    break;
                case "video":
                    result = Request.CreateResponse(HttpStatusCode.OK, video.GetAll());
                    break;
                default:
                    result = Request.CreateResponse(HttpStatusCode.BadRequest, "'" + type + "' is not a valid Action.");
                    break;
            }
            return result;
        }
        [HttpGet()]
        [Route("api/Media/{type}/{id}")]
        public HttpResponseMessage GetMediaById(string type, int id)
        {
            HttpResponseMessage result = null;
            switch (type.ToLower())
            {
                case "all":
                    result = Request.CreateResponse(HttpStatusCode.OK, media.Get(id));
                    break;
                case "images":
                    result = Request.CreateResponse(HttpStatusCode.OK, images.Get(id));
                    break;
                case "audio":
                    result = Request.CreateResponse(HttpStatusCode.OK, audio.Get(id));
                    break;
                case "video":
                    result = Request.CreateResponse(HttpStatusCode.OK, video.Get(id));
                    break;
                default:
                    result = Request.CreateResponse(HttpStatusCode.BadRequest, "'" + type + "' is not a valid Action.");
                    break;
            }
            return result;
        }

        [HttpGet()]
        [Route("api/Media/{type}/ByProject/{id}")]
        public HttpResponseMessage GetMediaByProject(string type, int id)
        {
            HttpResponseMessage result = null;
            switch (type.ToLower())
            {
                case "all":
                    result = Request.CreateResponse(HttpStatusCode.OK, media.GetByProject(id));
                    break;
                case "images":
                    result = Request.CreateResponse(HttpStatusCode.OK, images.GetByProject(id));
                    break;
                case "audio":
                    result = Request.CreateResponse(HttpStatusCode.OK, audio.GetByProject(id));
                    break;
                case "video":
                    result = Request.CreateResponse(HttpStatusCode.OK, video.GetByProject(id));
                    break;
                default:
                    result = Request.CreateResponse(HttpStatusCode.BadRequest, "'" + type + "' is not a valid Action.");
                    break;
            }
            return result;
        }

        [HttpGet()]
        [Route("api/Media/{type}/ByAlbum/{id}")]
        public HttpResponseMessage GetMediaByAlbum(string type, int id)
        {
            HttpResponseMessage result = null;
            switch (type.ToLower())
            {
                case "all":
                    result = Request.CreateResponse(HttpStatusCode.OK, media.GetByAlbum(id));
                    break;
                case "images":
                    result = Request.CreateResponse(HttpStatusCode.OK, images.GetByAlbum(id));
                    break;
                case "audio":
                    result = Request.CreateResponse(HttpStatusCode.OK, audio.GetByAlbum(id));
                    break;
                case "video":
                    result = Request.CreateResponse(HttpStatusCode.OK, video.GetByAlbum(id));
                    break;
                default:
                    result = Request.CreateResponse(HttpStatusCode.BadRequest, "'" + type + "' is not a valid Action.");
                    break;
            }
            return result;
        }
        #endregion

        #region Image Actions
        #endregion

        #region Audio Actions
        #endregion

        #region Video Actions
        #endregion
    }
}
