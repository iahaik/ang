
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ang.Models
{
    public class Group
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key]
        public int GroupId { get; set; }
        public string Name { get; set; }

        public List<Participant> Participants { get; set; }
    }
}
