using ITrabbleChatBotBusinessServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TrabbleChatBotBusinessServices
{
    public class ChatBotCustomerCareService: IChatBotCustomerCareService
    {
        public ChatBotCustomerCareService()
        {

        }

        public async Task<string> LoadCustomerCareReplyAsync()
        {
            return Environment.NewLine + "contact_us - show contact information."
                 + Environment.NewLine + Environment.NewLine + "tv_character - favorite tv character."
                 + Environment.NewLine + Environment.NewLine + "sgd_exchange_rates -  exchange rates.";
        }
    }
}
