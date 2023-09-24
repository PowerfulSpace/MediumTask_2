namespace SOLID_InterfaceSegregationPrinciple.Interfaces.Voice
{
    interface IVoiceMessage : IMessage
    {
        byte[] Voice { get; set; }
    }
}
