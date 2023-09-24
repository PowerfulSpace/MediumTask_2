
using SOLID_InterfaceSegregationPrinciple.Interfaces;
using SOLID_InterfaceSegregationPrinciple.Models;

IMessage emailMessage = new EmailMessage() { Text = "Привет, отправляю по почте"};
IMessage smsMessage = new SmsMessage() { Text = "Привет, отправляю смс" };
IMessage voiceMessage = new VoiceMessage();

emailMessage.Send();
smsMessage.Send();
voiceMessage.Send();


Console.ReadLine();




//Принцип разделения интерфейсов (Interface Segregation Principle) относится к тем случаям,
//когда классы имеют "жирный интерфейс", то есть слишком раздутый интерфейс,
//не все методы и свойства которого используются и могут быть востребованы.
//Таким образом, интерфейс получатся слишком избыточен или "жирным".