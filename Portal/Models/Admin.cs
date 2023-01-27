namespace Portal.Models
{
    public class Admin
    {
        public int AdminId { get; set; }
        public int UserId { get; set; }
        public string ServiceLength { get; set; }      
        public string MovingTo { get; set; }
        public string AlumniHomeAddress { get; set; }
        public virtual User User { get; set; }

    }
}
