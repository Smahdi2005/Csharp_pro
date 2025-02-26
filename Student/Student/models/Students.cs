namespace Student.models;

internal class Students : Users
{
    //set contructors//
    public Students(string firstName, string lastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }

    public Students(string firstName, string lastName, string nationalcode , string userRole) : this(firstName, lastName)
    {
        {
            nationalcode = Nationalcode;
            userRole = UserRole;
        }

    }

}
