using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace DI_example.Repository
{
    //IProductRepository.cs
    public interface IProductRepository
    {
        IEnumerable<Product> GetAll();
        Product Get(int id);
        Product Add(Product item);
        bool Update(Product item);
        bool Delete(int id);
    }
}