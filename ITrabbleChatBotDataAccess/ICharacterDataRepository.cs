using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ITrabbleChatBotDataAccess
{
    public interface ICharacterDataRepository
    {
        Task<Object> LoadCharacterDataAsync(string characterName);
    }
}
