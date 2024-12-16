namespace WebApplication8.Models
{
    public class Report
    {
        public int ID { get; private set; }
        public int ExecutorId { get; private set; }
        public string Time { get; private set; }
        public string Materials { get; private set; }
        public string Price { get; private set; }
        public string CauseMalfunction { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public DateTime FinishAt { get; private set; }

    }
}
