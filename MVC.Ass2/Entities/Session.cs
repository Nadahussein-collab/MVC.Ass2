namespace MVC.Ass2.Entities
{
    public class Session : BaseEntity
    {
        public string Description { get; set; }
        public int Capacity { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        public int TrainerId { get; set; } // FK
        public Trainer Trainer { get; set; }
    }
}
