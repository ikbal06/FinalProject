using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
//CORE KATMANI DİĞRE KATMANLARI REFERANS ALMAZ
namespace Core.DataAccess
{
    //sınıflandırmak istiyorum T yi
    //generic constraint
    //class demek referans tip demek
    //herhangi bir class eklemesin mesela benim elimdekilerin özelliği entity de olmaları
    //IEntity : IEntity olabilir ya da IEntity implemente edebilmeli
    //new(): new lenebilir olmalı hani IEntity interface old new lenemiyor ya ondan faydalı burda new demek

   public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        List<T> GetAll(Expression<Func<T, bool>> filter = null);
        //tek bir data getirmek için tek bir kredinin gelmesi mesela birçok hesabın var onlardan birini seçmende kullanılır. null deemek filtresşşz yani hepsi geliecektir    
        T Get(Expression<Func<T, bool>> filter);
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
