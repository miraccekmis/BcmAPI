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
    public class ChildCategoryManager : IChildCategoryService
    {
        IChildCategoryDal _childCategoryDal;
        public ChildCategoryManager(IChildCategoryDal childCategoryDal)
        {
            _childCategoryDal = childCategoryDal;
        }

        public IResult Add(ChildCategory childCategory)
        {
            _childCategoryDal.Add(childCategory);
            return new SuccessResult("Çocuk Kategori Eklendi.");
        }

        public IResult Delete(int childCategoryId)
        {
            _childCategoryDal.Delete(_childCategoryDal.Get(p => p.Id == childCategoryId));
            return new SuccessResult("Çocuk Kategori Silindi.");
        }

        public IDataResult<List<ChildCategory>> GetAll()
        {
            return new SuccessDataResult<List<ChildCategory>>(_childCategoryDal.GetAll().ToList());
        }

        public IDataResult<ChildCategory> GetById(int childCategoryId)
        {
            return new SuccessDataResult<ChildCategory>(_childCategoryDal.Get(c => c.Id == childCategoryId));
        }

        public IDataResult<List<ChildCategory>> GetListBySubCategory(int subCategoryId)
        {
            return new SuccessDataResult<List<ChildCategory>>(_childCategoryDal.GetAll(p => p.SubCategoryId == subCategoryId).ToList());
        }

        public IResult Update(ChildCategory childCategory)
        {
            _childCategoryDal.Update(childCategory);
            return new SuccessResult("Çocuk Kategori Güncellendi.");
        }
    }
}
