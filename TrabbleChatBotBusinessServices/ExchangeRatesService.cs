using ITrabbleChatBotBusinessServices;
using ITrabbleChatBotDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrabbleChatBotCommon.Domain;

namespace TrabbleChatBotBusinessServices
{
    public class ExchangeRatesService : IExchangeRatesService
    {
        private readonly IExchangeRatesRepository _exchangeRatesRepository;

        //Constructer
        public ExchangeRatesService(IExchangeRatesRepository exchangeRatesRepository)
        {
            this._exchangeRatesRepository = exchangeRatesRepository;
        }

        public async Task<ExchangeRates> LoadExchangeRatesAsync(string currencyCode)
        {
            return await this._exchangeRatesRepository.LoadExchangeRatesAsync(currencyCode);
        }
    }
}
