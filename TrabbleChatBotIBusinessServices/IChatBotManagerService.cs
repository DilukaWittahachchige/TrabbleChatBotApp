
namespace ITrabbleChatBotBusinessServices
{
    #region Directives
    using System;
    using System.Collections.Generic;
    using System.Text;
    using System.Threading.Tasks;
    #endregion

    /// <summary>
    ///  Service inerface which responsible for manage chat engine and user response 
    /// </summary>
    public interface IChatBotManagerService
    {
        Task LoadChatBotReplyAsync();
    }
}
