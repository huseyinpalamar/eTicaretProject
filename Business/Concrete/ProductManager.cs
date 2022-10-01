using Business.Abstract;
using Business.BusinessAspect.Autofac;
using Business.Constants;
using Business.ValidationRules.FluentValidation;
using Core.Aspects.Autofac.Validation;
using Core.CrossCuttingConcernes.Validation.FluentValidation;
using Core.Utilities.Business;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrate;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        // injection 
        IProductDal _productDal;
        ICategoryService _categoryService;
        public ProductManager(IProductDal productDal, ICategoryService categoryService )
        {
            _productDal = productDal;
             _categoryService= categoryService;
        }
        [SecuredOperation("admin")]
        [ValidationAspect(typeof(ProductValidator))]
        public IResult Add(Product product)
        {
          var result=  BusinessRules.Run(CehckIfProductCountOfCAtegoryCorrect(product.CategoryId), 
                                         CheckIfProductNameExists(product.ProductName), CheckIfCategoryCount());


            if (result !=null)// sorun burada kontrol et......
            {
                return result;
            }
            _productDal.Add(product);
            return new SuccessResult(Messages.ProductAdded);

            
        }

        public IResult Delete(Product product)
        {
            _productDal.Delete(product);
            return new SuccessResult("Silme İşlemi Başarılı");

        }

        [SecuredOperation("admin")]
        public IDataResult<List<Product>> GetAll()
        {
            // işkodları çalış>cak
            // yeterli ise  veri tabanına ekle emri vericek
            //if (datetime.now.hour == 22)
            //{
            //    return new errordataresult<list<product>>(messages.listingfailed);



            //}
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(), Messages.ListingSuccessful);


        }

        public IDataResult<List<Product>> GetAllByCategoryId(int categoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.CategoryId == categoryId));
        }

        public IDataResult<List<Product>> GetAllByUnitPrice(decimal min, decimal max)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.UnitPrice >= min && p.UnitPrice <= max));
        }

        public IDataResult<Product> GetById(int id)
        {
            return new SuccessDataResult<Product>(_productDal.Get(p => p.ProductId == id));
        }

        public IDataResult<List<ProductDetailDto>> GetProductDetail()
        {
            return new SuccessDataResult<List<ProductDetailDto>>(_productDal.GetProductDetail());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult();
        }

        private IResult CehckIfProductCountOfCAtegoryCorrect(int categoryId)
        {
            var result = _productDal.GetAll(p => p.CategoryId == categoryId).Count();

            if (result > 20)
            {
                return new ErrorResult("Bu kategori dolu");
            }
            return new SuccessResult();
        }
        private IResult CheckIfProductNameExists(string productName)
        {

            var result = _productDal.GetAll(p => p.ProductName == productName).Any();

            if (result)
            {
                return new ErrorResult(Messages.ProductNameAlreadyExsists);
            }
            return new SuccessResult();

        }

        private IResult CheckIfCategoryCount()
        {
            var result=_categoryService.GetAll();

            if (result.Data.Count >= 15)
            {
                return new ErrorResult();
            }
            return new SuccessResult();
        }

    }
}
