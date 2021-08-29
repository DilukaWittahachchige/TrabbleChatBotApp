using ITrabbleChatBotDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrabbleChatBotCommon.Domain;
using TrabbleChatBotDataAccess.WServices;

namespace TrabbleChatBotDataAccess
{
    public class ExchangeRatesRepository: IExchangeRatesRepository
    {
        /// <summary>
        ///  Return Exchange rates from public API
        /// </summary>
        /// <param name="currencyCode"></param>
        /// <returns></returns>
        public async Task<ExchangeRates> LoadExchangeRatesAsync(string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
                return new ExchangeRates();

            var exchangeWS = new ExchangeRateWS();
            return await exchangeWS.LoadExchangeRates(currencyCode);
        }
    }
}
