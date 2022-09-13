using Core.DataAccess;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
// Veri erişim katmanım
namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal : IEntityRepository<Product>
    {

        // Global Değişken
        List<Product> _products;

        // constroctor
        // similasyon için veri tabanı oluşturduk.
        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{ProductId=1,CategoryId=2, ProductName="Bardak", UnitPrice=5, UnitsInStock=5},
                new Product{ProductId=2,CategoryId=3, ProductName="Bilgisyar", UnitPrice=8, UnitsInStock=3},
                new Product{ProductId=3,CategoryId=3, ProductName="Telefon", UnitPrice=9, UnitsInStock=8},
                new Product{ProductId=4,CategoryId=1, ProductName="ELma", UnitPrice=3, UnitsInStock=7},
                new Product{ProductId=5,CategoryId=1, ProductName="Armut", UnitPrice=10, UnitsInStock=5}


            };   
        }

        public void Add(Product entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(Product entity)
        {
            throw new NotImplementedException();
        }

        public Product Get(Expression<Func<Product, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Product> GetAll(Expression<Func<Product, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public void Update(Product entity)
        {
            throw new NotImplementedException();
        }
    }
}
