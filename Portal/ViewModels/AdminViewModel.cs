using Portal.Models;
using System.Collections.Generic;

namespace Portal.ViewModels
{
    public class AdminViewModel
    {
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public string Division { get; set; }
        public string Level { get; set; }
        public string ServiceLength { get; set; }
        public string MovingTo { get; set; }
        public string AlumniHomeAddress { get; set; }
        public int AdminId { get; set; }
        public int UserId { get; set; }
    }
}
