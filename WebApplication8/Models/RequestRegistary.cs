namespace WebApplication8.Models
{
    public class RequestRegistary
    {
        public int ID { get; private set; }
        public string Priority { get; private set; }
        public string SaveInformation { get; private set; }
        public DateTime CreateAt { get; private set; }
        public DateTime UpdateAt { get; private set; }
        public DateTime FinishAt { get; private set; }


    }
}
