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
    public class EfSubCategoryDal : EfEntityRepositoryBase<SubCategory, DataBaseContext>,ISubCategoryDal
    {
        //public List<SubCategoryDetailDto> GetSubCategoryDetails()
        //{
        //    using (DataBaseContext context = new DataBaseContext())
        //    {
        //        var result = from c in context.Categories
        //            join
        //                mc in context.MiddleCategories on c.CategoryId equals mc.CategoryId
        //            join sc in context.SubCategories on mc.MiddleCategoryId equals sc.MiddleCategoryId
        //            select new SubCategoryDetailDto
        //            {
        //                SubCategoryId = sc.SubCategoryId,
        //                SubCategoryName = sc.SubCategoryName,
        //                MiddleCategoryName = mc.MiddleCategoryName,
        //                CategoryName = c.CategoryName
        //            };
        //        return result.ToList();
        //    }
        //}
    }
}
