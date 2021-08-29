using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITrabbleChatBotBusinessServices
{
    public interface ICharacterDataService
    {
        Task<object> LoadCharacterDataAsync(string currencyCode);
    }
}
