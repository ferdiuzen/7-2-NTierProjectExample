using CoreLayer.DataAccess.Concrete.EntityFramework;
using CoreLayer.DataAccess.Concrete.EntityFramework.Contexts;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfProductDal : EfEntityRepositoryBase<Product, NorthwindContext>, IProductDal
    {


    }
}
