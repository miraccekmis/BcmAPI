using Business.Abstract;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ProductManager : IProductService
    {
        IProductDal _productDal;
        public ProductManager(IProductDal productDal)
        {
            _productDal = productDal;
        }
        public IResult Add(Product product)
        {
            _productDal.Add(product);
            return new SuccessResult("Ürün Eklendi.");
        }

        public IResult Delete(int productId)
        {
            _productDal.Delete(_productDal.Get(p => p.Id == productId));
            return new SuccessResult("Ürün Silindi.");
        }

        public IDataResult<List<Product>> GetAll()
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll().ToList());
        }

        public IDataResult<Product> GetById(int productId)
        {
            return new SuccessDataResult<Product>(_productDal.Get(c => c.Id == productId));
        }

        public IDataResult<List<Product>> GetListBySubCategory(int subCategoryId)
        {
            return new SuccessDataResult<List<Product>>(_productDal.GetAll(p => p.SubCategoryId == subCategoryId).ToList());
        }

        public IResult Update(Product product)
        {
            _productDal.Update(product);
            return new SuccessResult("Ürün Güncellendi.");
        }

    }
}
