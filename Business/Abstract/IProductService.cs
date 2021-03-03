using Core.Utililies.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResult<List<Product>> GetAll();
        IDataResult<List<Product>> GetAllByCategoryId(int id);
        IDataResult<List<Product>> GetByUnitPrice(decimal min, decimal max);
        IDataResult<List<ProductDetailDto>> GetProductDetails();
        IDataResult<Product> GetById(int productId);
        IResult Add(Product product); //void var yani data yok ondan IDataResult yapmadık
        IResult Update(Product product);
        IResult AddTransactionalTest(Product product);  //tutarlılığı korur iki veri tabanı işlemi var
    }
}
