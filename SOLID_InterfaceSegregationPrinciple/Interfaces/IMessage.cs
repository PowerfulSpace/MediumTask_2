namespace SOLID_InterfaceSegregationPrinciple.Interfaces
{
    interface IMessage
    {
        void Send();
        string ToAddress { get; set; }
        string FromAddress { get; set; }
    }
}
