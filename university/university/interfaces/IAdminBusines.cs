using university.Entities;

namespace university.interfaces;

public interface IAdminBusiness<T> where T : class
{
    bool Add(T item);
    bool Update(T item);
    bool Delete(T item);


}
