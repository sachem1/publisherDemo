using System;
using System.Security.Cryptography.X509Certificates;

namespace SimpleFactory
{
    public interface IProduct
    {
        void ShowProduct();
    }

    public class SimpleProduct : IProduct
    {
        public void ShowProduct()
        {
            Console.WriteLine("获取了简单产品");
        }
    }
    public class ComplexProduct : IProduct
    {
        public void ShowProduct()
        {
            Console.WriteLine("获取了复杂产品");
        }
    }

}