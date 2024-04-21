
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System.Text;

public class RabbitMQService
{
    private IConnection;
    private IModel _channel;

    public RabbitMQService(string host, int port, string username, string password)
    {
        var factory = new ConnectionFactory() { HostName = host, Port = port, UserName = username, Password = password };
        _connection = factory.CreateConnection();
        _channel = _connection.CreateModel();
    }

    public void SendMessage(string queue, string message)
    {
        _channel.QueueDeclare(queue: queue, durable: false, exclusive: false, autoDelete: false, arguments: null);
        var body = Encoding.UTF8.GetBytes(message);
        _channel.BasicPublish(exchange: "", routingKey: queue, basicProperties: null, body: body);
    }

    public void ReceiveMessages(string queue, Action<string> onMessageReceived)
    {
        _channel.QueueDeclare(queue: queue, durable: false, exclusive: false, autoDelete: false, arguments: null);
        var consumer = new EventingBasicConsumer(_channel);
        consumer.Received += (model, ea) =>
        {
            var body = ea.Body.ToArray();
            var message = Encoding.UTF8.GetBytes(objects) ;
            onMessageReceived(message);
            };
        _channel.BasicConsume(queue: queue, autoAck: true, consumer: consumer);
    }

    public void Dispose()
     {
        _channel.Dispose();
        _connection.Dispose();
     }
}
