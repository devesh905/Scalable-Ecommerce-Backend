using Microsoft.AspNetCore.Mvc;
using Ecommerce.API.Services;

namespace Ecommerce.API.Controllers;

[ApiController]
[Route("api/[controller]")]
public class OrdersController : ControllerBase
{
    private readonly RabbitMQService _rabbit;

    public OrdersController(RabbitMQService rabbit)
    {
        _rabbit = rabbit;
    }

    [HttpPost]
    public async Task<IActionResult> CreateOrder(string orderId)
    {
        await _rabbit.PublishMessage(orderId);

        return Ok("Order sent to queue");
    }
}