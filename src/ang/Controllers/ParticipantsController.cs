
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ang.Models;
using ang.Repository.Interface;

namespace ang.Controllers
{
    [Route("api/[controller]")]
    public class ParticipantsController : Controller
    {
        private IParticipantRepository _repository;

        public ParticipantsController(IParticipantRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public IEnumerable<Participant> GetGroup()
        {
            return _repository.GetAll();
        }

        [HttpGet("{id}")]
        public Participant GetGroup(int id)
        {
            return _repository.Get(id);
        }

        [HttpPost]
        public void Post([FromBody]Participant participant)
        {
            _repository.Create(participant);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody]Participant participant)
        {
            if (_repository.Get(id) != null)
            {
                _repository.Update(participant);
            }
            else
            {
                _repository.Create(participant);
            }
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var participant = _repository.Get(id);
            if (participant != null)
            {
                _repository.Delete(id);
            }
        }
    }
}
