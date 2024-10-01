using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISP
{
    public class Product
    {

    }
    public class ProductRepository : IRepository<Product>, ISearchable<Product>
    {
        public void Create(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Product Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Product> GetAll()
        {
            throw new NotImplementedException();
        }

        public IList<Product> Search(string name)
        {
            Console.WriteLine("isme göre arandı");
            return new List<Product>();

        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
