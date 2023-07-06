using Microsoft.AspNetCore.SignalR;

namespace TextEditor.Hubs
{
    public class TextEditorHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveMessage", user , message);
        }
    }
}