using ITrabbleChatBotDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using TrabbleChatBotDataAccess.WServices;

namespace TrabbleChatBotDataAccess
{
    public class CharacterDataRepository : ICharacterDataRepository
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="currencyCode"></param>
        /// <returns></returns>
        public async Task<Object> LoadExchangeRatesAsync(string currencyCode)
        {
            if (string.IsNullOrWhiteSpace(currencyCode))
                return new object();

            var characterWS = new CharacterDataWS();
            return await characterWS.LoadCharacterInfo(currencyCode);
        }
    }
}
