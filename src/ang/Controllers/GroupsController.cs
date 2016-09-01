
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ang.Models;
using ang.Repository.Interface;

namespace ang.Controllers
{
    [Route("api/[controller]")]
    public class GroupsController : Controller
    {
        private IGroupRepository _repository;

        public GroupsController(IGroupRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Group> GetGroup()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Group GetGroup(int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        public void Post([FromBody]Group group)
        {
            _repository.Create(group);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Group group)
        {
            if (_repository.Get(id) != null)
            {
                _repository.Update(group);
            }
            else
            {
                _repository.Create(group);
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var group = _repository.Get(id);
            if (group != null)
            {
                _repository.Delete(id);
            }
        }
    }
}
