using CoreLayer.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Product:IEntity  //IEntity inherit edilen tablo veri tabanı tablosudur
    {
        public int ProductId { get; set; }

        public int CategoryId { get; set; }

        public string ProductName { get; set; }

        public string QuantityPerUnit { get; set; }

        public short UnitsInStock { get; set; }

        public decimal UnitPrice { get; set; }


    }
}
