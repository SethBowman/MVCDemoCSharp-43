using MVCDemoCSharp_43.Models;
using System.Data;
using Dapper;

namespace MVCDemoCSharp_43
{
    public class ProductRepo : IProductRepo
    {
        private readonly IDbConnection _conn;
        public ProductRepo(IDbConnection conn)
        {
            _conn = conn;
        }
        public IEnumerable<Product> GetAllProducts()
        {
            return _conn.Query<Product>("SELECT * FROM products;");
        }
    }
}
