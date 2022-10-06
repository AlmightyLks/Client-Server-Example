using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyBigProject.Server.Services;
using MyBigProject.Shared;

namespace MyBigProject.Server.Controllers.Api
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly MessageService _messageService;

        public MessageController(MessageService messageService)
        {
            _messageService = messageService;
        }

        // Endpoint that receives data
        [HttpPost]
        public void AddNewMessage([FromBody] Message message)
        {
            // Store data
            _messageService.AddMessage(message);
        }
    }
}
