﻿using Core.Utilities.Results;
using Entities.Concrete;
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
        IDataResult<Product> GetById(int productId);
        IDataResult<List<Product>> GetListBySubCategory(int subCategoryId);
        IResult Add(Product product);
        IResult Update(Product product);
        IResult Delete(int productId);
    }
}
