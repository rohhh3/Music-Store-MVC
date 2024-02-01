namespace MusicStore.Models
{
    public class InvoiceModel
    {
        public int InvoiceNumber { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime DueDate { get; set; }

        public string ItemName { get; set; }
        public decimal ItemPrice { get; set; }
    }
}
