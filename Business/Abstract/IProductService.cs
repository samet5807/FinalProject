using Core.Utilities.Results;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IProductService
    {
        IDataResults<List<Product>> GetAll();

        IDataResults<List<Product>> GetAllByCategoryId(int id);

        

        

        IResult Add(Product product);

        

        IDataResults<Product> GetById(int productId);

    }
}
