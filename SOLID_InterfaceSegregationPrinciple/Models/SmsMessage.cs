using SOLID_InterfaceSegregationPrinciple.Interfaces.Text;

namespace SOLID_InterfaceSegregationPrinciple.Models
{
    class SmsMessage : ITextMessage
    {
        public string Text { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public string ToAddress { get; set; } = "";
        public void Send() => Console.WriteLine($"Отправляем по Sms сообщение: {Text}");
    }
}
