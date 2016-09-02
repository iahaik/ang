
using System;
using System.Collections.Generic;
using ang.Models;
using ang.Repository.Interface;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace ang.Repository
{
    public class ParticipantRepository : BaseRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(GroupContext context) : base(context)
        {
        }

        public override List<Participant> GetAll()
        {
            var result = Context.Participants.Include(x => x.Group).ToList();
            return result;
        }

        public override Participant Get(int id)
        {
            return Context.Participants.Include(x => x.Group).FirstOrDefault(x => x.ParticipantId == id);
        }
    }
}
