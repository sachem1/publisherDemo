using System;

namespace FactoryMethod
{
    public class SimpleProduct:IProduct
    {
        public void GetProduct()
        {
            Console.WriteLine("我是简单产品实例！");
        }
    }
    public class ComplexProduct : IProduct
    {
        public void GetProduct()
        {
            Console.WriteLine("我是复杂产品实例！");
        }
    }
}