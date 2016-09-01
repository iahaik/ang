
using System.Collections.Generic;

namespace ang.Models
{
    public class Group
    {
        public int GroupId { get; set; }
        public string Name { get; set; }

        public List<Participant> Participants { get; set; }
    }
}
