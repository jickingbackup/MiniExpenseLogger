using System.Collections.Generic;

namespace DataApp.Core.Abstracts
{
    public interface IController<T> where T : class 
    {
        T Get(object id);
        List<T> Get();
        bool Add(T entity);
        bool Update(T entity);
        bool Delete(object id);
    }
}
