using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfChildCategoryDal : EfEntityRepositoryBase<ChildCategory, DataBaseContext>,IChildCategoryDal
    {
        //public List<MiddleCategoryDetailDto> GetMiddleCategoryDetails()
        //{
        //    using (DataBaseContext context = new DataBaseContext())
        //    {
        //        var result = from mc in context.MiddleCategories
        //                     join c in context.Categories on mc.CategoryId equals c.CategoryId
        //                     select new MiddleCategoryDetailDto()
        //                     {
        //                         MiddleCategoryId = mc.MiddleCategoryId,
        //                         MiddleCategoryName = mc.MiddleCategoryName,
        //                         CategoryName = c.CategoryName
        //                     };
        //        return result.ToList();
        //    }
        //}
    }
}
