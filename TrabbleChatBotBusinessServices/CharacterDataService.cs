using ITrabbleChatBotBusinessServices;
using ITrabbleChatBotDataAccess;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrabbleChatBotBusinessServices
{
    public class CharacterDataService: ICharacterDataService
    {

        private readonly ICharacterDataRepository _characterDataRepository;

        //Constructer
        public CharacterDataService(ICharacterDataRepository characterDataRepository)
        {
            this._characterDataRepository = characterDataRepository;
        }

        public async Task<object> LoadCharacterDataAsync(string characterName)
        {
            var characterInfo = string.Empty;
            return this._characterDataRepository.LoadCharacterDataAsync(characterName);

 
        }
    }
}
