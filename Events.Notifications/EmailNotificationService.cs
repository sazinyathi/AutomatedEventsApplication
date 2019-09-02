using Events.Intefarces.Services;
using Events.Interfaces.Repositories;
using Events.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Events.Notifications
{
    public class EmailNotificationService : INotificationService
    {
        private readonly IEventRepository _eventRepository;
        public EmailNotificationService(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
        }

        public async Task<Event> SendEmailNotificationForEventAsyc(int eventId)
        {
            var eventDetails = await _eventRepository.GetEventByIDAsync(eventId);
            if (eventDetails == null)
                return null;
            SendEmail(eventDetails);
            eventDetails.IsMailSent = true;
            await _eventRepository.UpdateEventAsync(eventDetails);
            return eventDetails;
        }
        public static void SendEmail(Event events)
        {
            string smtpAddress = "smtp.gmail.com";
            int portNumber = 587;
            bool enableSSL = true;
            string emailFromAddress = "sazinyathi3@gmail.com"; //Sender Email Address  
            string password = "Bongimusa@1"; //Sender Password  
            List<string> emailToAddress = events.ActiveRecipients; //Receiver Email Address  
            string subject = events.EventName;
            string body = "Good Afternoon All <br/> Please join us on the 27 August 2019 at the "+ events .EventLocation+ " at 4pm to bid farewell to, <strong>Jobe</strong>.Snacks and drinks will be served";
            using (MailMessage mail = new MailMessage())
            {
                mail.From = new MailAddress(emailFromAddress);
                for (int i = 0; i < emailToAddress.Count; i++)
                {
                    mail.To.Add(emailToAddress[i]);
                }
               
                mail.Subject = subject;
                mail.Body = body;
                mail.IsBodyHtml = true;

                //mail.Attachments.Add(new Attachment("D:\\TestFile.txt"));//--Uncomment this to send any attachment  
                using (SmtpClient smtp = new SmtpClient(smtpAddress, portNumber))
                {
                    smtp.Credentials = new NetworkCredential(emailFromAddress, password);
                    smtp.EnableSsl = enableSSL;
                    smtp.Send(mail);

                }
            }
        }

        
    }
}
