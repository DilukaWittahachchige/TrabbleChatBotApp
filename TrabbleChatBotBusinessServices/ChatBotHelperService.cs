using ITrabbleChatBotBusinessServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrabbleChatBotBusinessServices
{
    public class ChatBotHelperService : IChatBotHelperService
    {
        public ChatBotHelperService()
        {

        }

        public string LoadHelpMessage()
        {
            return Environment.NewLine + "contact_us - show contact information."
                 + Environment.NewLine + Environment.NewLine + "tv_character - favorite tv character."
                 + Environment.NewLine + Environment.NewLine + "sgd_exchange_rates -  exchange rates.";
        }
    }
}
