using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        void Add(Product product);
        void Delete(Product product);
        void Update(Product product);

        List<Product> GetAll();

        List<Product> GetAllByCategory(int categoryId);
    }
}
