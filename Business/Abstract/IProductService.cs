using Core.Utilities.Result.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<Product> GetById(int id);   
        IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max);
        IDataResult<List<Product>> GetAllByCategoryId(int categoryId);
        IDataResult<List<ProductDetailDto>> GetProductDetail();
        IResult Add(Product product);
        IResult Update(Product product);   
        IResult Delete(Product product);

    }
}
