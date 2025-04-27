namespace CoreMvcPortfolioProject.DAL.Entities
{
    public class Message
    {
        public int MessageId { get; set; }
        public string SenderName { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public string Email { get; set; }
        public DateTime SendDate { get; set; }
        public bool IsRead { get; set; }
    }
}
