using Business.Abstract;
using DataAccess.Abstract;
using DataAccess.Concreate.InMemory;
using Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concreate
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;

        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }

        public void Add(Product product)
        {
            _productDal.Add(product);
        }

        public void Delete(Product product)
        {
            _productDal.Delete(product);
        }

        public List<Product> GetAll()
        {
            //İş kodları
            return _productDal.GetAll();
            
        }

        public List<Product> GetAllByCategory(int categoryId)
        {
            return _productDal.GetAllByCategory(categoryId);
        }

        public void Update(Product product)
        {
            _productDal.Update(product);
        }
    }
}
