using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
    public class PhoneMessageService:IMessageService
    {
        public string SendMessage()
        {
            return "发送手机短信";
        }
    }
}
