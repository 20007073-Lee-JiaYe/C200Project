using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using SendGrid;
using SendGrid.Helpers.Mail;

public class SendGridUtl
{
    private static IConfiguration config =
      new ConfigurationBuilder()
         .SetBasePath(Directory.GetCurrentDirectory())
         .AddJsonFile("appsettings.json")
         .Build()
         .GetSection("SendGridSettings");

    // send email to user based on admin's approval of their comment
    public static async Task SendEMail(string emailAddress, string name, string comment, string status)
    {
        var apiKey = config.GetValue<String>("APIKey");
        // authenticate with sendgrid API
        var client = new SendGridClient(apiKey);
        // create the email along with details
        var msg = new SendGridMessage()
        {
            From = new EmailAddress(config.GetValue<String>("AutenticatedEmail"), "Healthy You And Me Team"),
            Subject = "Your recent comment has been reviewed",
            //PlainTextContent = "and easy to do anywhere, even with C#",
            HtmlContent = CreateBody(name, comment, status)
        };
        // attach the reciever's email address to the message object
        msg.AddTo(new EmailAddress(emailAddress, name));
        var response = await client.SendEmailAsync(msg).ConfigureAwait(false);
    }

    private static string CreateBody(string name, string comment, string status)
    {
        string body = File.ReadAllText("C:\\Users\\20007073\\Desktop\\RP\\Y2 Sem 2\\C200 Special Project\\Presentation\\V5_C200_Official (2)\\C200_Official\\Views\\Shared\\email.html");
        body = body.Replace("{Name}", name);
        body = body.Replace("{comment}", comment);
        if (status == "approved")
        {
            body = body.Replace("{message}", "Your comment below has been <b>approved</b>:");
        }
        else if (status == "rejected")
        {
            body = body.Replace("{message}", "Your comment below has been <b>rejected</b>:");
        }
        return body;
    }
}