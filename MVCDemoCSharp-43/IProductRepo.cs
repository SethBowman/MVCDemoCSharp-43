using MVCDemoCSharp_43.Models;

namespace MVCDemoCSharp_43
{
    public interface IProductRepo
    {
        public IEnumerable<Product> GetAllProducts();
    }
}
