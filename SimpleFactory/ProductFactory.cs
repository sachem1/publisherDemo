namespace SimpleFactory
{
    public class ProductFactory
    {
        public IProduct GetProduct(ProductType type)
        {
            switch (type)
            {
                    case ProductType.Simple:
                        return new SimpleProduct();
                    case ProductType.Complex:
                    return new ComplexProduct();
            }
            return (IProduct) default(object);
        }
    }
}