using ITrabbleChatBotBusinessServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using TrabbleChatBotBusinessServices;

namespace TrabbleChatBot
{
    class Program
    {
        static void Main(string[] args)
        {

            //DI Implementation 
            //TODO : Need to move into another class 
            var serviceProvider = new ServiceCollection()
             .AddSingleton<IChatBotHelperService, ChatBotHelperService>()
             .AddSingleton<IChatBotManagerService, ChatBotManagerService>()
             .BuildServiceProvider();

            var bar = serviceProvider.GetService<IChatBotManagerService>();
            bar.LoadChatBotReplyAsync();
        }
    }
}
