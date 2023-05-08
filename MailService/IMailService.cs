using System;
using System.Collections.Generic;
using System.Text;

namespace MailService
{
   public interface IMailService
   {
       public void send(string title, string to, string body); 
   }
}
