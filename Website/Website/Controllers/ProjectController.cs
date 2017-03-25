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
        [Route("api/Projects/{title}")]
        public HttpResponseMessage GetProjectByTitle(string title)
        {
            return Request.CreateResponse(HttpStatusCode.OK, repository.GetByTitle(title));
        }
    }
}
