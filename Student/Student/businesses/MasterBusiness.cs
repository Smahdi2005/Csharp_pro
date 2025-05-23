using Student.interfaces;
using Student.models;

namespace Student.businesses;
internal interface IMasterBusiness : IBaseBusiness<Masters>
{
    public void Add(Masters item)
    {
        throw new NotImplementedException();
    }

    public void get(Masters item)
    {
        throw new NotImplementedException();
    }

    public List<Masters> get()
    {
        throw new NotImplementedException();
    }

}
