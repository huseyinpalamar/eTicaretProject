using Business.Abstract;
using Business.Constants;
using Core.Utilities.Result.Abstract;
using Core.Utilities.Result.Concrate;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;
        public CategoryManager()
        {

        }
        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            if (category.CategoryName.Length>5)
            {
                _categoryDal.Add(category);
                return new SuccessResult(Messages.ProductAdded);
            }
            return new ErrorResult();
            
        }

        public IResult Delete(Category category)
        {
            _categoryDal.Delete(category);
            return new SuccessResult(Messages.ProductRemoved);

        }
        // Datayı liste halinde çek.
        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(), Messages.ListingSuccessful);

        }

        public IDataResult<Category> GetById(int id)
        {
            var result = _categoryDal.Get(c => c.CategoryId == id);
            if (result==null)
            {
                return new ErrorDataResult<Category>("Bu id ye karşılık ürün bulunamadı");
            }
            return new SuccessDataResult<Category>(result,"Listeleme Başarılı...");
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult(Messages.UpateSuccessful);
        }
       
    }
}
