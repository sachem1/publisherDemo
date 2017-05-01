using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisherDemo
{
    /// <summary>
    /// 事件订阅服务
    /// </summary>
    public interface ISubscriptionService
    {
        IList<IConsumer<T>> GetSubscriptions<T>();
    }
}
