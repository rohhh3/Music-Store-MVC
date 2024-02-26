using MusicStore.Models;

namespace MusicStore.Services
{
    public class CurrencyService : ICurrencyService
    {
        public (string SelectedCurrency, decimal ExchangeRate) GetCurrencyInfo(HttpContext httpContext)
        {
            string? selectedCurrency = httpContext.Session.GetString("SelectedCurrency");
            decimal? exchangeRate = httpContext.Session.GetDecimal("ExchangeRate");

            if (exchangeRate == 0)
            {
                exchangeRate = 1;
            }

            // Set default values if session values are null
            string effectiveCurrency = !string.IsNullOrEmpty(selectedCurrency) ? selectedCurrency : "PLN";
            decimal effectiveExchangeRate = exchangeRate.HasValue ? exchangeRate.Value : 1M;

            return (effectiveCurrency, effectiveExchangeRate);
        }


    }
}
