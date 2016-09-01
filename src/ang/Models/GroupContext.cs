
using Microsoft.EntityFrameworkCore;

namespace ang.Models
{
    public class GroupContext : DbContext
    {
        public GroupContext(DbContextOptions<GroupContext> options) : base(options)
        {
        }

        public DbSet<Group> Groups { get; set; }
        public DbSet<Participant> Participants { get; set; }
    }
}
