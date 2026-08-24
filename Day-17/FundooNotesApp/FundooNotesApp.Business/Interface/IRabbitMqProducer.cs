namespace FundooNotesApp.Business
{
    public interface IRabbitMqProducer
    {
        void SendMessage<T>(T message, string queueName);
    }
}