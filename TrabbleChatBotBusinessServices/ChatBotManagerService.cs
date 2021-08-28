using ITrabbleChatBotBusinessServices;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Telegram.Bot;
using Telegram.Bot.Args;

namespace TrabbleChatBotBusinessServices
{
    public class ChatBotManagerService : IChatBotManagerService
    {
        private static readonly TelegramBotClient bot = new TelegramBotClient("1988158546:AAEGTAT9akP-ygoHh2xwpGo3UvELL8kbdWk");

        private readonly IChatBotHelperService _helperService;

        //Constructer
        public ChatBotManagerService(IChatBotHelperService helperService)
        {
            this._helperService = helperService;
        }

        public async Task LoadChatBotReplyAsync()
        {
            // TODO:  Need to integrate chat bot engine 
            // TODO:  Pass user message to chat bot engine and select most suitable reply - Plan to implement Algo
            bot.OnMessage += Csharpcornerbotmessage;
            bot.StartReceiving();
            Console.ReadLine();
            bot.StopReceiving();

        }

        private void Csharpcornerbotmessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                PrepareQuestionnaires(e);
        }
        private void PrepareQuestionnaires(MessageEventArgs e)
        {
            if (e.Message.Text.ToLower() == "hi")
                bot.SendTextMessageAsync(e.Message.Chat.Id, "hello Sir/Madam" + Environment.NewLine + "welcome to Trabble chat bot." + Environment.NewLine + "How may i help you ?");
            else if (e.Message.Text.ToLower().Contains("/help"))
                bot.SendTextMessageAsync(e.Message.Chat.Id, _helperService.LoadHelpMessage());
        }
    }
}
