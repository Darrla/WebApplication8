namespace WebApplication8.Models
{
    public class RequestExecute
    {
        public int ID { get; private set; }
        public int ExecutorId { get; private set; }
        public string ChangesMade { get; private set; }
        public string OrderParts { get; private set; }
        public string CoordinationWork { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public DateTime FinishAt { get; private set; }


    }
}
