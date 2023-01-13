using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace CoreLayer.DataAccess.Abstract
{
   public interface IEntityRepository<T> //Generic Tip
    {
        List<T> GetList(Expression<Func<T, bool>> filter=null);
        //landa expression yapısı
        T Get(Expression<Func<T, bool>> filter);

        //Yukarıdaki kodlarda ; Data listelemesi için Generik
        //tipte  lambda expression yapısı delege olarak tanımlandı
        //filter null verilirse tüm datalar listelenir

        void Add(T entity);
        void Update(T entity);

        void Delete(T entity);


    }
}
