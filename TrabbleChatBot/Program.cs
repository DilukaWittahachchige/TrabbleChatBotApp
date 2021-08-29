using ITrabbleChatBotBusinessServices;
using ITrabbleChatBotDataAccess;
using Microsoft.Extensions.DependencyInjection;
using System;
using TrabbleChatBotBusinessServices;
using TrabbleChatBotDataAccess;

namespace TrabbleChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            //DI Implementation 
            //TODO : Need to move into another class 
            var serviceProvider = new ServiceCollection()
             .AddSingleton<IExchangeRatesRepository, ExchangeRatesRepository>()
             .AddSingleton<ICharacterDataRepository, CharacterDataRepository>()

             .AddSingleton<IChatBotCustomerCareService, ChatBotCustomerCareService>()
             .AddSingleton<IExchangeRatesService, ExchangeRatesService>()
             .AddSingleton<IChatBotHelperService, ChatBotHelperService>()
             .AddSingleton<ICharacterDataService, CharacterDataService>()
             .AddSingleton<IChatBotManagerService, ChatBotManagerService>()
             .BuildServiceProvider();

            var bar = serviceProvider.GetService<IChatBotManagerService>();
            bar.LoadChatBotReplyAsync();
        }
    }
}
