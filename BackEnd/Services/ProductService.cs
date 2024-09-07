using JSCdata;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace Services
{
    public class ProductService : IProductService
    {
        private JSCDBContext _jscDB;
        public ProductService(JSCDBContext jscDb)
        {
            this._jscDB = jscDb;
        }
        public IEnumerable<Product> getProducts()
        {
            return _jscDB.Products.ToList();
        }

        public string addProduct(Product product)
        {
            try
            {
                _jscDB.Products.Add(product);
                _jscDB.SaveChanges();
                return "Added";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

    }
}