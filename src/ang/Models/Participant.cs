
namespace ang.Models
{
    public class Participant
    {
        public int ParticipantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GroupId { get; set; }
        public Group Group { get; set; }
    }
}
