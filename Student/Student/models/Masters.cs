namespace Student.models;

internal class Masters : Users
{
    //set constructors//
    public Masters(string firstName , string lastName) 
    {
        firstName = FirstName;
        lastName = LastName;
    }

    public Masters(string firstName , string lastName, string nationalCode,string userRole) : this(firstName , lastName)
    {
        nationalCode = Nationalcode;
        UserRole = userRole;
    
    }
}
