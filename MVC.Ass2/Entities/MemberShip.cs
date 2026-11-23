using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace MVC.Ass2.Entities
{
    public class MemberShip : BaseEntity
    {
        public int PlanId { get; set; }
        public Plans Plan { get; set; }

        public int MemberId { get; set; }
        public Member Member { get; set; }


        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        [NotMapped]
        public string Status => StartDate > DateTime.Now ? "Upcoming"
                              : EndDate > DateTime.Now ? "Active"
                              : "Expired";
    }
}
