
using SOLID_SingleResponsibilityPrinciple.Models;
using SOLID_SingleResponsibilityPrinciple;



MobileStore store = new MobileStore(
    new ConsolePhoneReader(), new GeneralPhoneBinder(),
    new GeneralPhoneValidator(), new TextPhoneSaver());
store.Process();


Console.ReadLine();