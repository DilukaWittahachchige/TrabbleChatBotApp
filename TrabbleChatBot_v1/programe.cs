
using ITrabbleChatBotBusinessServices;
using Microsoft.Extensions.DependencyInjection;
using System;
using Telegram.Bot;
using Telegram.Bot.Args;
using TrabbleChatBotBusinessServices;

namespace DilukaTrabbleChatBot
{
    #region Directives

    #endregion

    //class telegrambot
    //{
    //    /// <summary>
    //    /// Declare Telegrambot object 
    //    /// Static - Load to memory at once ,when application load time ,can use whole application life cycle 

    //    //TODO: Need to load Key from Databse or constent file 
    //    private static readonly TelegramBotClient bot = new TelegramBotClient("1988158546:AAEGTAT9akP-ygoHh2xwpGo3UvELL8kbdWk");

    //    /// <summary>
    //    ///  Main method for console application 
    //    /// </summary>
    //    /// <param name="args"></param>
    //    public static void Main(string[] args)
    //    {
    //        bot.OnMessage += Csharpcornerbotmessage;
    //        bot.StartReceiving();
    //        Console.ReadLine();
    //        bot.StopReceiving();

    //    }

    //    /// <summary>
    //    /// Handle bot webhook
    //    /// </summary>
    //    /// <param name="sender"></param>
    //    /// <param name="e"></param>
    //    private static void Csharpcornerbotmessage(object sender, MessageEventArgs e)
    //    {
    //        if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
    //            PrepareQuestionnaires(e);
    //    }
    //    public static void PrepareQuestionnaires(MessageEventArgs e)
    //    {
    //         if (e.Message.Text.ToLower() == "hi")
    //            bot.SendTextMessageAsync(e.Message.Chat.Id, "hello Sir/Madam" + Environment.NewLine + "welcome to Trabble chat bot." + Environment.NewLine + "How may i help you ?");
    //    }

    //}
    public class Program
    {
        public static void Main(string[] args)
        {
            //setup our DI
            var serviceProvider = new ServiceCollection()
                //.AddLogging()
                //.AddSingleton<IFooService, FooService>()
                .AddSingleton<IChatBotManagerService, ChatBotManagerService>()
                .BuildServiceProvider();

            //configure console logging
            //serviceProvider
            //    .GetService<ILoggerFactory>()
            //    .AddConsole(LogLevel.Debug);

            //var logger = serviceProvider.GetService<ILoggerFactory>()
            //    .CreateLogger<Program>();
            //logger.LogDebug("Starting application");

            //do the actual work here
            var bar = serviceProvider.GetService<IChatBotManagerService>();
            bar.LoadChatBotReplyAsync();

            //logger.LogDebug("All done!");

        }
    }

}
