using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
    class Program
    {
        static void Main(string[] args)
        {
           //在消费者内部抽象实现
            EMailService service = new EMailService();
            NotifycationSystem sys2 = new NotifycationSystem(service);
            Console.WriteLine(sys2.InterestingEventHappened());

            ServiceLocator locator = new ServiceLocator();

            //使用定位器，将抽象实现的任务转移到消费者的外部
            NotifycationSystem sys = new NotifycationSystem(locator);

            Console.WriteLine(sys.InterestingEventHappened());

            //使用弱类型
            NotifycationSystem sys1 = new NotifycationSystem(locator, typeof(PhoneMessageService));

            Console.WriteLine(sys1.InterestingEventHappened());

            Console.ReadLine();
        }
    }

    public class ServiceLocator : IServiceLocator
    {
        public IMessageService GetMessageService()
        {
            return new EMailService();
        }

        public object GetService(Type serviceType)
        {
            if (serviceType.Equals(typeof(EMailService)))
                return new EMailService();
            if (serviceType.Equals(typeof(PhoneMessageService)))
                return new PhoneMessageService();
            return null;
        }

       public EMailService GetService()
       {
           return new EMailService();
       }
    }
}
