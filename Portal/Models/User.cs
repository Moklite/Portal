using System;
using System.Collections.Generic;

namespace Portal.Models
{
    public class User
    {
        public int UserId { get; set; }
        public string StaffName { get; set; }
        public string Gender { get; set; }
        public string Division { get; set; }
        public string Unit { get; set; }
        public string Level { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public DateTime Birthday { get; set; }
        //biss unit
        public string BizUnitInformedMe { get; set; }
        public string BizUnitInvolvedMe { get; set; }
        public string BizUnitPositiveCulture { get; set; }
        public string BizUnitOnTheJobTraining { get; set; }
        public string BizUnitAssignedWork { get; set; }
        public string BizUnitImprovementIdeas { get; set; }
        //my job
        public string MyJobValuableWorkExp { get; set; }
        public string MyJobSkills { get; set; }
        public string MyJobManageableWorkload { get; set; }
        public string MyJobClearlyDefined { get; set; }
        public string MyJobWorkLifeHarmony { get; set; }
        //performance manager
        public string PMAccessible { get; set; }
        public string PMRespectsMe { get; set; }
        public string PMAppreciates { get; set; }
        public string isPMRoleModel { get; set; }
        public string isPMSupportive { get; set; }
        public string isPMResilient { get; set; }
        //performance development
        public string MyPDQualityDiscussion { get; set; }
        public string MyPDWellPrepared { get; set; }
        public string MyPDFeedback { get; set; }
        public string MyPDAlign { get; set; }
        //my career
        public string isMyCareerSatisfactory { get; set; }
        public string isMyCareerExpectationMet { get; set; }
        public string isMyCareerpromotion { get; set; }
        //compensation
        public string isMyCompensationPeers { get; set; }
        public string isMyCompensationMarket { get; set; }
        public string isMyCompensationPerf { get; set; }

        public virtual ICollection<Admin> Admin { get; set; }
    }
}
