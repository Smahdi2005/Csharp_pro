namespace university.interfaces;

internal interface IBaseBusiness<T> where T : class
{
    bool Add(T item);

    bool update(T item);
}
