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
          var serviceProvider = new ServiceCollection()

         .AddSingleton<IChatBotManagerService, ChatBotManagerService>()
         .BuildServiceProvider();

          var bar = serviceProvider.GetService<IChatBotManagerService>();
          bar.LoadChatBotReplyAsync();
        }
    }
}
