using Ehs.Reporting.MR.Services;
using Ehs.Reporting.MR.Settings;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using Moq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Ehs.Reporting.Test
{
    public class EmailServiceTest
    {
        //IConfiguration config = new ConfigurationBuilder()
        //           .SetBasePath(Directory.GetCurrentDirectory())
        //           .AddJsonFile("app-settings-test.json").Build();

        //ILogger<EmailService> mock = Mock.Of<ILogger<EmailService>>();


        //[Fact]
        //public async Task SendEmailTest()
        //{
            

        //    IEmailService emailService = new EmailService(Options.Create(GetEmailSettings(config)), mock);

        //    await emailService.Send("sahil.sachdeva@enhesa.com", "Test mail", "Test mail please ignore.");
        //}

        //private EmailSettings GetEmailSettings(IConfiguration config)
        //{
        //    return new EmailSettings
        //    {
        //        FromEmail = config["Email:FromEmail"],
        //        Host = config["Email:Host"],
        //        Password = config["Email:Password"],
        //        Port = config["Email:Port"]
        //    };
        //}
    }

}

