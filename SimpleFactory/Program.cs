using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactory
{
    class Program
    {
        /// <summary>
        /// 优点：简单工厂模式能够根据外界给定的信息，决定究竟应该创建哪个具体类的对象。明确区分了各自的职责和权力，有利于整个软件体系结构的优化。
        /// 缺点：很明显工厂类集中了所有实例的创建逻辑，容易违反GRASPR的高内聚的责任分配原则
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ProductFactory factory=new ProductFactory();


            IProduct simple = factory.GetProduct(ProductType.Simple);
            simple.ShowProduct();

            IProduct complex = factory.GetProduct(ProductType.Complex);
            complex.ShowProduct();
            Console.ReadLine();
        }
    }
}
