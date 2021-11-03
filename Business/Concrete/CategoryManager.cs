using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
            _categoryDal.Add(category);
            return new SuccessResult("Kategori Eklendi.");
        }

        public IResult Delete(int categoryId)
        {
            _categoryDal.Delete(_categoryDal.Get(p => p.Id == categoryId));
            return new SuccessResult("Kategori Silindi.");
        }

        public IDataResult<List<Category>> GetAll()
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll().ToList());
        }

        public IDataResult<Category> GetById(int categoryId)
        {
            return new SuccessDataResult<Category>(_categoryDal.Get(c => c.Id == categoryId));
        }

        public IDataResult<List<Category>> GetListByBrand(int brandId)
        {
            return new SuccessDataResult<List<Category>>(_categoryDal.GetAll(p => p.BrandId == brandId).ToList());
        }

        public IResult Update(Category category)
        {
            _categoryDal.Update(category);
            return new SuccessResult("Kategori Güncellendi.");
        }
    }
}
