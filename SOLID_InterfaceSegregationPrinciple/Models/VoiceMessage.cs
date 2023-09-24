using SOLID_InterfaceSegregationPrinciple.Interfaces.Voice;

namespace SOLID_InterfaceSegregationPrinciple.Models
{
    class VoiceMessage : IVoiceMessage
    {
        public string ToAddress { get; set; } = "";
        public string FromAddress { get; set; } = "";

        public byte[] Voice { get; set; } = Array.Empty<byte>();
        public void Send() => Console.WriteLine("Передача голосовой почты");
    }
}
