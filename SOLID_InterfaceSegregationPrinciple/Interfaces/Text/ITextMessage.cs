namespace SOLID_InterfaceSegregationPrinciple.Interfaces.Text
{
    interface ITextMessage : IMessage
    {
        string Text { get; set; }
    }
}
