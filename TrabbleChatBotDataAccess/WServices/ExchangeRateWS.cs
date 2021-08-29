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
        private const string ExchangeRatesUrl = "https://open.er-api.com/v6/latest/";

        public async Task<ExchangeRates> LoadExchangeRates(string currencyCode)
        {
            var apiManager = new APIManager();
            var paramdData = new List<string>();
            paramdData.Add(currencyCode);
            return await apiManager.LoadAPIResponse(new ExchangeRates(), paramdData, ExchangeRatesUrl);
        }
    }
}
