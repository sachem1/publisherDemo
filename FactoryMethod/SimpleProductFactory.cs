namespace FactoryMethod
{
    public class SimpleProductFactory:IFactory
    {
        public IProduct CreateProduct()
        {
            return new SimpleProduct();
        }
    }
    public class ComplexProductFactory : IFactory
    {
        public IProduct CreateProduct()
        {
            return new ComplexProduct();
        }
    }
}