
using ang.Models;
using ang.Repository.Interface;

namespace ang.Repository
{
    public class ParticipantRepository : BaseRepository<Participant>, IParticipantRepository
    {
        public ParticipantRepository(GroupContext context) : base(context)
        {
        }
    }
}
