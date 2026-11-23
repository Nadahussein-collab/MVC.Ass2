using System.Net;
using System.Reflection;

namespace MVC.Ass2.Entities
{
    public class GymUser : BaseEntity
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Enums.Gender Gender { get; set; }
        public Address Address { get; set; }
    }
}
