using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
    public class NotifycationSystem
    {
        //属性注入
        public IMessageService Service{get;set;}

        public NotifycationSystem(IMessageService service)
        {
            Service = service;
        }
        public NotifycationSystem(IServiceLocator locator)
        {
            Service = locator.GetMessageService();
        }

        //构造函数注入
        public NotifycationSystem(IServiceLocator locator, Type type)
        {
            Service = (IMessageService)locator.GetService(type);
        }
    

        public string InterestingEventHappened()
        {
            return Service.SendMessage();
        }
    }
}
