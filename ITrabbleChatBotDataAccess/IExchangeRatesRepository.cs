using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrabbleChatBotCommon.Domain;

namespace ITrabbleChatBotDataAccess
{
    public interface IExchangeRatesRepository
    {
        //Later plan to load exchange rates from scheduler(every hour) daily then insert/update into database finally load  exchange rates from database 
        Task<ExchangeRates> LoadExchangeRatesAsync(string currencyCode);
    }
}
