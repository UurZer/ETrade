using System;
using System.Collections.Generic;
using System.Text;
using Core.Utilities.Results;
using Entities.Concrete;

namespace Business.Abstract
{
    public interface IBasketService
    {
        IDataResult<List<Basket>> GetAll();
        IResult Add(Basket product);
        IResult Delete(Basket product);
        IResult Update(Basket product);
    }
}
