using ITrabbleChatBotBusinessServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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

        private readonly IExchangeRatesService _exchangeRatesService;

        //Constructer
        public ChatBotManagerService(
            IChatBotHelperService helperService,
            IExchangeRatesService exchangeRatesService
            )
        {
            this._helperService = helperService;
            this._exchangeRatesService = exchangeRatesService;
        }

        public async Task LoadChatBotReplyAsync()
        {
            // TODO:  Need to integrate chat bot engine 
            // TODO:  Pass user message to chat bot engine and select most suitable reply - Plan to implement Algo
            bot.OnMessage += Loadbotmessage;
            bot.StartReceiving();
            Console.ReadLine();
            bot.StopReceiving();

        }

        private void Loadbotmessage(object sender, MessageEventArgs e)
        {
            if (e.Message.Type == Telegram.Bot.Types.Enums.MessageType.Text)
                PrepareQuestionnaires(e);
        }
        private void PrepareQuestionnaires(MessageEventArgs e)
        {
            if (e.Message.Text.ToLower().Trim() == "hi")
                bot.SendTextMessageAsync(e.Message.Chat.Id, "hello Sir/Madam" + Environment.NewLine + "welcome to Trabble chat bot." + Environment.NewLine + "How may i help you ?");
            else if (e.Message.Text.ToLower().Contains("/help"))
                bot.SendTextMessageAsync(e.Message.Chat.Id, _helperService.LoadHelpMessage());
            else if (e.Message.Text.ToLower().Contains("/sgd_exchange_rates"))
                //RODO: Need to get user input 
                bot.SendTextMessageAsync(e.Message.Chat.Id,this.LoadExchangeRatesString());
        }

        private string LoadExchangeRatesString()
        {
            var exchangeRatesList = _exchangeRatesService.LoadExchangeRatesAsync("SGD").Result;
            var exchangeRatesString = string.Empty;

            //Reflection
            foreach (PropertyInfo propertyInfo in exchangeRatesList.rates.GetType().GetProperties())
            {
                var name = propertyInfo.Name;
                var value = propertyInfo.GetValue(exchangeRatesList.rates, null);

                var exchangeRate = $"{Environment.NewLine}{name} = {value}{Environment.NewLine}";
                exchangeRatesString = $"{ exchangeRatesString}{exchangeRate}";
            }

            return exchangeRatesString;
        }
    }
}
