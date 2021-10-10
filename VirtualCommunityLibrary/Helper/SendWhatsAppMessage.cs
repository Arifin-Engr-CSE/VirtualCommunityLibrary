using System;
using System.Text;
using Twilio;
using Twilio.Rest.Api.V2010.Account;
using Twilio.Types;

namespace VirtualCommunityLibrary.Helper
{
    public static class SendWhatsAppMessage
    {
        public static void SendMessage(string userName, string pass)
        {
            var accountSid = "AC377628fd4691b175a622af6aac225ab2";
            var authToken = "a4effb2fe66eaddc8fbdfad72cd016b9";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:+8801969026829"));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = "Your CommunityLibrary code is " + pass;
            //Your CommunityLibrary code is 1238432

            var message = MessageResource.Create(messageOptions);
            //Console.WriteLine(message.Body);
        }
        public static void SendMessage(string userName, string pass, string Number)
        {
            var accountSid = "AC377628fd4691b175a622af6aac225ab2";
            var authToken = "a4effb2fe66eaddc8fbdfad72cd016b9";
            TwilioClient.Init(accountSid, authToken);

            var messageOptions = new CreateMessageOptions(
                new PhoneNumber("whatsapp:" + Number));
            messageOptions.From = new PhoneNumber("whatsapp:+14155238886");
            messageOptions.Body = "Your CommunityLibrary code is " + pass;
            //Your CommunityLibrary code is 1238432

            var message = MessageResource.Create(messageOptions);
            //Console.WriteLine(message.Body);
        }
    }
}