using System.Collections.Generic;
using ang.Models;
using ang.Repository.Interface;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace ang.Repository
{
    public class GroupRepository : BaseRepository<Group>, IGroupRepository
    { 
        public GroupRepository(GroupContext context) : base(context)
        {
        }

        public override List<Group> GetAll()
        {
            var result = Context.Groups.Include(x => x.Participants).ToList();
            return result;
        }

        public override Group Get(int id)
        {
            return Context.Groups.Include(x => x.Participants).FirstOrDefault(x => x.GroupId == id);
        }
    }
}
