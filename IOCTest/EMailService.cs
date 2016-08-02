using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
   public  class EMailService:IMessageService
    {
       public string SendMessage()
       {
           return "发送通知邮件";
       }
    }
}
