using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using TrabbleChatBotCommon.Domain;
using System.Text.Json;

namespace TrabbleChatBotDataAccess.WServices
{
    public class ExchangeRateWS
    {
        public async Task<ExchangeRates> LoadExchangeRates(string currencyCode)
        {
            ExchangeRates exchangeRates = new ExchangeRates();
            using (var httpClient = new HttpClient())
            {
                using (var response = await httpClient.GetAsync("https://open.er-api.com/v6/latest/" + currencyCode))
                {
                    if (response.StatusCode == System.Net.HttpStatusCode.OK)
                    {
                        string apiResponse = await response.Content.ReadAsStringAsync();
                        exchangeRates = JsonSerializer.Deserialize<ExchangeRates>(apiResponse);
                    }
                    else
                    {

                    }
                }
            }
            return exchangeRates;
        }
    }
}
