using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        private readonly IGenericRepository<PostRevision> _revisionRepo;
        private readonly IUnitOfWork _uow;

        public PostController(IGenericRepository<Post> repo, IGenericRepository<PostRevision> revisionRepo, IUnitOfWork uow)
        {
            _repo = repo;
            _revisionRepo = revisionRepo;
            _uow = uow;
        }

        // GET: api/Post
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult Get()
        {
            var list = _repo.Get();

            if (list == null)
                return NotFound();

            var dtolist = Mapper.Map<IEnumerable<PostOutViewModel>>(list);

            return Ok(dtolist);
        }

        // GET: api/Post/1
        [System.Web.Mvc.HttpGet]
        public IHttpActionResult Get(int id)
        {
            var getById = (_repo.GetByKey(id));

            if (getById == null)
                return NotFound();

            return Ok(Mapper.Map<PostOutViewModel>(getById));
        }

        // POST: api/Post
        [System.Web.Mvc.HttpPost]
        public IHttpActionResult Post([FromBody]PostInViewModel value)
        {
            if (value == null) return NotFound();

            try
            {
                //Create a new Post
                var newPost = Mapper.Map<Post>(value);
                var newRes = newPost.Revisions.FirstOrDefault();
                newPost.CreatedOn = DateTime.UtcNow;
                newPost.Revisions = null;
                _repo.Insert(newPost);
                _uow.Save();

                //Create a new Revision
                if (newPost.Id != 0 && newRes != null)
                {
                    newRes.PostId = newPost.Id;
                    newRes.ModifiedOn = DateTime.UtcNow;
                    _revisionRepo.Insert(newRes);
                    _uow.Save();

                    newPost.Revisions = new Collection<PostRevision>{ newRes };
                    //Return outcome
                    return Ok(Mapper.Map<PostOutViewModel>(newPost));
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }

            return NotFound();
        }

        // PUT: api/LOL/5
        [System.Web.Mvc.HttpPut]
        public IHttpActionResult Put(int id, [FromBody]PostOutViewModel value)
        {
            return NotFound();
        }

        // DELETE: api/LOL/5
        [System.Web.Mvc.HttpDelete]
        public IHttpActionResult Delete(int id)
        {
            try
            {
                var item = _repo.GetByKey(id);
                if (item != null)
                {
                    _repo.DeleteByKey(id);
                    _uow.Save();

                    return Ok(Mapper.Map<PostOutViewModel>(item));
                }
            }
            catch (Exception e)
            {
                return NotFound();
            }

            return NotFound();
        }
    }
}