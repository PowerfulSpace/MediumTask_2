using SOLID_InterfaceSegregationPrinciple.Interfaces.Text.Email;

namespace SOLID_InterfaceSegregationPrinciple.Models
{
    class EmailMessage : IEmailMessage
    {
        public string Text { get; set; } = "";
        public string Subject { get; set; } = "";
        public string FromAddress { get; set; } = "";
        public string ToAddress { get; set; } = "";

        public void Send() => Console.WriteLine($"Отправляем по Email сообщение: {Text}");
    }
}
