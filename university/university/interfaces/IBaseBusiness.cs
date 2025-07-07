using university.Entities;

namespace university.interfaces;

public interface IBaseBusiness<T> where T : class
{
    bool Add(T item);
    bool update(T item);

    public Student GetDataFromDb(string userName ,string password);

    
    
}
