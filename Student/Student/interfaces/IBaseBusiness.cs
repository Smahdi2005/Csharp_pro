namespace Student.interfaces;

internal interface IBaseBusiness<T>
{
    public void Add(T item);
    public List<T> get();
}
