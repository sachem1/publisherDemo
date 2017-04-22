using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            string factoryType = ConfigurationManager.AppSettings["FactoryType"];
            string dllName = ConfigurationManager.AppSettings["DllName"];

            var currnetAssembly = System.Reflection.Assembly.GetExecutingAssembly();
            string codeBase = currnetAssembly.CodeBase.ToLower().Replace(currnetAssembly.ManifestModule.Name.ToLower(), string.Empty);
            IFactory factory = Assembly.LoadFrom(Path.Combine(codeBase, dllName)).CreateInstance(factoryType) as IFactory;
            if (factory != null)
            {
                IProduct product = factory.CreateProduct();
                product.GetProduct();
            }
        }
    }
}
