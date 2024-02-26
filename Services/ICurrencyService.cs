namespace MusicStore.Services
{
    public interface ICurrencyService
    {
        (string SelectedCurrency, decimal ExchangeRate) GetCurrencyInfo(HttpContext httpContext);

    }
}

