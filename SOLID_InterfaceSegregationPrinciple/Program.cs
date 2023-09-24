
using SOLID_InterfaceSegregationPrinciple.Interfaces;
using SOLID_InterfaceSegregationPrinciple.Models;

IMessage emailMessage = new EmailMessage() { Text = "Привет, отправляю по почте"};
IMessage smsMessage = new SmsMessage() { Text = "Привет, отправляю смс" };
IMessage voiceMessage = new VoiceMessage();

emailMessage.Send();
smsMessage.Send();
voiceMessage.Send();


Console.ReadLine();