using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IChildCategoryService
    {
        IDataResult<List<ChildCategory>> GetAll();
        IDataResult<ChildCategory> GetById(int childCategoryId);
        //IDataResult<List<MiddleCategoryDetailDto>> GetMiddleCategoryDetails();
        IDataResult<List<ChildCategory>> GetListBySubCategory(int subCategoryId);
        IResult Add(ChildCategory childCategory);
        IResult Update(ChildCategory childCategory);
        IResult Delete(int childCategoryId);

    }
}
