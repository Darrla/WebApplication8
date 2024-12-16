namespace WebApplication8.Models
{
    public class RequestRemont
    {
        public int ID { get; private set; }
        public string Equipment { get; private set; }
        public string SerialNumber { get; private set; }
        public string Description { get; private set; }
        public int ClientId { get; private set; }
        public string Priority { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public DateTime FinishAt { get; private set; }
        public string Status { get; private set; }
    }
}
