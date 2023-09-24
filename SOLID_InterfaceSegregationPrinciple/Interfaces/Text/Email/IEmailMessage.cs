namespace SOLID_InterfaceSegregationPrinciple.Interfaces.Text.Email
{
    interface IEmailMessage : ITextMessage
    {
        string Subject { get; set; }
    }
}
