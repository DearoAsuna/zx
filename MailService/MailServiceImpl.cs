using System;
using System.Collections.Generic;
using System.Text;
using ConfigService;
using LogServices;

namespace MailService
{
    public class MailServiceImpl:IMailService
    {
        private readonly ILogProvider log;
       // private readonly IconfigService config;
       private readonly IConfigReader config;

        public MailServiceImpl(ILogProvider log, IConfigReader config)
        {
            this.log = log;
            this.config = config;
        }
        public void send(string title, string to, string body)
        {
            this.log.LogInfo("发邮件");
            var name = this.config.GetValue("SmtpClient");
            var value = this.config.GetValue("Username");
            var value1 = this.config.GetValue("Password");
            Console.WriteLine($"地址{name}   {value}   {value1}");
            Console.WriteLine($"{title}   {to}   {body}");
            this.log.LogInfo("完毕");
        }
    }
}
