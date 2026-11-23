namespace MVC.Ass2.Entities
{
    public class Trainer : GymUser
    {
        public Enums.Speciality Speciality { get; set; }

        public ICollection<Session> Sessions { get; set; }
    }
}
