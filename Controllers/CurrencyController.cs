using Microsoft.AspNetCore.Mvc;
using MusicStore.Models;
using System.Web;

namespace MusicStore.Controllers
{
    public class CurrencyController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> ChangeCurrency(string selectedCurrency)
        {
            // Retrieve exchange rate for the selected currency
            decimal exchangeRate = await GetExchangeRate(selectedCurrency);

            // Store the selected currency and exchange rate (you can use session, cookie, or database)
            HttpContext.Session.SetString("SelectedCurrency", selectedCurrency);
            HttpContext.Session.SetDecimal("ExchangeRate", exchangeRate);

            Console.BackgroundColor = ConsoleColor.Red;
            Console.WriteLine($"Selected Currency: {selectedCurrency}");
            Console.ResetColor();

            // Get the current URL and add the selectedCurrency as a query parameter
            var returnUrl = HttpContext.Request.Headers["Referer"].ToString();
            if (!string.IsNullOrEmpty(returnUrl))
            {
                var uriBuilder = new UriBuilder(returnUrl);
                var query = HttpUtility.ParseQueryString(uriBuilder.Query);
                query["selectedCurrency"] = selectedCurrency;
                uriBuilder.Query = query.ToString();
                returnUrl = uriBuilder.ToString();
            }

            // Redirect to the previous page with the updated selectedCurrency parameter
            return Redirect(returnUrl);
        }

        private async Task<decimal> GetExchangeRate(string currencyCode)
        {
            if (currencyCode.Equals("PLN", StringComparison.OrdinalIgnoreCase))
            {
                // If the selected currency is PLN, no need to fetch exchange rate
                return 1M;
            }

            // Fetch exchange rate from the API for non-PLN currencies
            string apiUrl = $"http://api.nbp.pl/api/exchangerates/rates/a/{currencyCode}/?format=json";
            using (HttpClient client = new HttpClient())
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.WriteLine($"Fetching exchange rate for {currencyCode} from API...");
                Console.ResetColor();

                HttpResponseMessage response = await client.GetAsync(apiUrl);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"API Response for {currencyCode}: {jsonResult}");
                    Console.ResetColor();

                    var rateData = Newtonsoft.Json.JsonConvert.DeserializeObject<ExchangeRateData>(jsonResult);

                    // Log the exchange rate to the console
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Exchange rate for {currencyCode}: {rateData?.Rates?.FirstOrDefault()?.Mid ?? 1M}");
                    Console.ResetColor();

                    // Assuming the API always returns a single rate
                    return rateData?.Rates?.FirstOrDefault()?.Mid ?? 1M;
                }
                else
                {
                    // Handle error
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Error fetching exchange rate for {currencyCode}. Status code: {response.StatusCode}");
                    Console.ResetColor();
                    return 1M; // Default to 1 if the exchange rate cannot be fetched
                }
            }
        }
    }
}
