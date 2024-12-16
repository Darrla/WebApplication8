namespace WebApplication8.Models
{
    public class Monitoring
    {
        public int ID { get; private set; }
        public string ProcessingTime { get; private set; }
        public string QuialityWork { get; private set; }
        public string Expenses { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public DateTime FinishAt { get; private set; }

    }
}
