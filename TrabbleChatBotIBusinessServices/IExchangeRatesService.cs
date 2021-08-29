using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrabbleChatBotCommon.Domain;

namespace ITrabbleChatBotBusinessServices
{
    public interface IExchangeRatesService
    {
        Task<ExchangeRates> LoadExchangeRatesAsync(string currencyCode);
    }
}
