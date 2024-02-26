namespace MusicStore.Models
{
    public class ExchangeRateData
    {
        public string Table { get; set; }
        public string Currency { get; set; }
        public string Code { get; set; }
        public List<ExchangeRate> Rates { get; set; }
    }
}
