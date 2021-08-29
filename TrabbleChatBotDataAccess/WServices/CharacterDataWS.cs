using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrabbleChatBotDataAccess.WServices
{

    //https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&exintro=&explaintext=&titles=Deepika_Padukone

    public class CharacterDataWS
    {
        // TODO : Load from const file or database
        private const string WikiUrl = "https://en.wikipedia.org/w/api.php?format=json&action=query&prop=extracts&exintro=&explaintext=&titles=";

        public async Task<Object> LoadCharacterInfo(string characterName)
        {
            var apiManager = new APIManager();
            var paramdData = new List<string>();
            paramdData.Add(characterName);
            return await apiManager.LoadDyanamicAPIResponse(paramdData, WikiUrl);
        }
    }
}
