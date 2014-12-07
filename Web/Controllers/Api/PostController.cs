using System.Collections.Generic;
using System.Linq;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Core.DomainModel.Frontpage;
using Core.DomainServices;
using Web.Models.Post;

namespace Web.Controllers.Api
{
    [RequireHttps]
    public class PostController : ApiController
    {
        private readonly IGenericRepository<Post> _repo;

        public PostController(IGenericRepository<Post> repo)
        {
            _repo = repo;
        }

        // GET: api/Post
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult Get()
        {
            var list = _repo.Get();

            if (list == null)
                return NotFound();

            var dtolist = Mapper.Map<IEnumerable<PostViewModel>>(list);

            return Ok(dtolist);
        }

        // GET: api/Post/1
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult Get(int id)
        {
            var getById = (_repo.GetByKey(id));

            if (getById == null)
                return NotFound();

            return Ok(Mapper.Map<PostViewModel>(getById));
        }

        [System.Web.Mvc.HttpPost]
        public IHttpActionResult Post(int id)
        {
            var getById = (_repo.GetByKey(id));

            if (getById == null)
                return NotFound();

            return Ok(Mapper.Map<PostViewModel>(getById));
        }
    }
}