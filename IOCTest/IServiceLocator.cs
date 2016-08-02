using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IOCTest
{
    /// <summary>
    /// 将抽象实现的任务转移到消费类的外部，这样可以保证消费类和被消费类均不产生代码修改
    /// </summary>
    public interface IServiceLocator
    {
        IMessageService GetMessageService();
        object GetService(Type serviceType);

        //T GetService<T>();
    }
}
