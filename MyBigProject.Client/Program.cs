using MyBigProject.Shared;
using System.Text;
using System.Text.Json;

namespace MyBigProject.Client
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            HttpClient client = new HttpClient();

            while (true)
            {
                Console.Write("Write something: ");
                string messageContent = Console.ReadLine();

                Message message = new Message()
                {
                    Author = "Client 123",
                    Content = messageContent
                };

                string json = JsonSerializer.Serialize(message);

                StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
                HttpResponseMessage response = await client.PostAsync("http://localhost:5284/api/Message/", stringContent);
            }
        }
    }
}



