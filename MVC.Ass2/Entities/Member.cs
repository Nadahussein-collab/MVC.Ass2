namespace MVC.Ass2.Entities
{
    public class Member : GymUser
    {
        public string? Photo { get; set; }

        public ICollection<MemberShip> Plans { get; set; }
    }
}
