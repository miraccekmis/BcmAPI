using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface ISubCategoryService
    {
        IDataResult<List<SubCategory>> GetAll();
        IDataResult<SubCategory> GetById(int subCategoryId);
        IDataResult<List<SubCategory>> GetListByCategory(int categoryId);
        //IDataResult<List<SubCategoryDetailDto>> GetSubCategoryDetails();
        IResult Add(SubCategory subCategory);
        IResult Update(SubCategory subCategory);
        IResult Delete(int subCategoryId);
    }
}
