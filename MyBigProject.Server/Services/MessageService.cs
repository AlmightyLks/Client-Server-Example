using MyBigProject.Shared;

namespace MyBigProject.Server.Services
{
    // Pretend this is some kinda database or whatever to store information it received
    // Where adding a new message means something has to be done or whatever
    public class MessageService
    {
        public List<Message> Messages { get; } = new List<Message>();

        public void AddMessage(Message message)
        {
            Messages.Add(message);
        }
    }
}
