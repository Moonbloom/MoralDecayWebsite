using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;
using AutoMapper;
using Core.DomainModel;
using Core.DomainServices;
using Web.Models;

namespace Web.Controllers.Api
{
    [RequireHttps]
    [System.Web.Http.Authorize]
    public class TestController : ApiController
    {
        private readonly IGenericRepository<Test> _repo;

        public TestController(IGenericRepository<Test> repo)
        {
            _repo = repo;
        }

        // GET: api/Test
        public IHttpActionResult Get()
        {
            var list = _repo.Get();

            if (list == null)
                return NotFound();

            var vmlist = Mapper.Map<IEnumerable<TestViewModel>>(list);

            return Ok(vmlist);
        }

        // GET: api/Test/1
        public IHttpActionResult Get(int id)
        {
            var getById = (_repo.GetByKey(id));

            if (getById == null)
                return NotFound();

            return Ok(Mapper.Map<TestViewModel>(getById));
        }
    }
}