using RabbitMQ.Client;
using System.Text;

namespace Ecommerce.API.Services;

public class RabbitMQService
{
    public async Task PublishMessage(string message)
    {
        var factory = new ConnectionFactory()
        {
            HostName = "rabbitmq"
        };

        await using var connection = await factory.CreateConnectionAsync();
        await using var channel = await connection.CreateChannelAsync();

        await channel.QueueDeclareAsync(
            queue: "orderQueue",
            durable: false,
            exclusive: false,
            autoDelete: false,
            arguments: null);

        var body = Encoding.UTF8.GetBytes(message);

        await channel.BasicPublishAsync(
            exchange: "",
            routingKey: "orderQueue",
            body: body);
    }
}