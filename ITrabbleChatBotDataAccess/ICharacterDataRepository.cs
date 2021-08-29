using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITrabbleChatBotDataAccess
{
    public interface ICharacterDataRepository
    {
        //Later plan to load exchange rates from scheduler(every hour) daily then insert/update into database finally load  exchange rates from database 
        Task<Object> LoadExchangeRatesAsync(string currencyCode);
    }
}
