using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class SubCategoryManager : ISubCategoryService
    {
        ISubCategoryDal _subCategoryDal;

        public SubCategoryManager(ISubCategoryDal subCategoryDal)
        {
            _subCategoryDal = subCategoryDal;
        }

        public IResult Add(SubCategory subCategory)
        {
            _subCategoryDal.Add(subCategory);
            return new SuccessResult("Alt Kategori Eklendi.");
        }

        public IResult Delete(int subCategoryId)
        {
            _subCategoryDal.Delete(_subCategoryDal.Get(p => p.Id == subCategoryId));
            return new SuccessResult("Alt Kategori Silindi.");
        }

        public IDataResult<List<SubCategory>> GetAll()
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetAll().ToList());
        }

        public IDataResult<SubCategory> GetById(int subCategoryId)
        {
            return new SuccessDataResult<SubCategory>(_subCategoryDal.Get(c => c.Id == subCategoryId));
        }

        public IDataResult<List<SubCategory>> GetListByCategory(int categoryId)
        {
            return new SuccessDataResult<List<SubCategory>>(_subCategoryDal.GetAll(p => p.CategoryId == categoryId).ToList());
        }

        //public IDataResult<List<SubCategoryDetailDto>> GetSubCategoryDetails()
        //{
        //    return new SuccessDataResult<List<SubCategoryDetailDto>>(_subCategory.GetSubCategoryDetails());
        //}

        public IResult Update(SubCategory subCategory)
        {
            _subCategoryDal.Update(subCategory);
            return new SuccessResult("Alt Kategori Güncellendi.");
        }
    }
}
