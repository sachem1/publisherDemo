using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisherDemo
{
    /// <summary>
    /// 消费者
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IConsumer<T>
    {
        void HandlerEvent(T eventMessage);
    }
}
