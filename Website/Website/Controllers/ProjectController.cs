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
    public class ProjectController : ApiController
    {
        ProjectRepository repository = new ProjectRepository();
        MediaRepository<Media> media = new MediaRepository<Media>();
        ImageRepository images = new ImageRepository();
        AudioRepository audio = new AudioRepository();
        VideoRepository video = new VideoRepository();

        [HttpGet()]
        [Route("api/Projects")]
        public HttpResponseMessage GetAllProjects()
        {
            return Request.CreateResponse(HttpStatusCode.OK, repository.GetAll());
        }

        [HttpGet()]
        [Route("api/Projects/{id}")]
        public HttpResponseMessage GetProjectById(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, repository.Get(id));
        }

        [HttpGet()]
        [Route("api/Projects/{id}/Media")]
        public HttpResponseMessage GetProjectMedia(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, media.GetByProject(id));
        }

        [HttpGet()]
        [Route("api/Projects/{id}/Images")]
        public HttpResponseMessage GetProjectImages(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, images.GetByProject(id));
        }

        [HttpGet()]
        [Route("api/Projects/{id}/Audio")]
        public HttpResponseMessage GetProjectAudio(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, audio.GetByProject(id));
        }

        [HttpGet()]
        [Route("api/Projects/{id}/Video")]
        public HttpResponseMessage GetProjectVideo(int id)
        {
            return Request.CreateResponse(HttpStatusCode.OK, video.GetByProject(id));
        }
    }
}
