using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace publisherDemo
{
    public interface IEventPublisher
    {
        void Publish<T>(T eventMessage);
    }
}
