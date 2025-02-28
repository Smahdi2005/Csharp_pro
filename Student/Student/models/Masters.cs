namespace Student.models;

internal class Masters : Users
{
    //set constructors//
    public Masters(string FirstName , string LastName , string NationalCode) 
    {
        FirstName = FirstName;
        LastName = LastName;
        Nationalcode = NationalCode;
        //check that user dont enter null data//
        
        bool isnullFirstName = string.IsNullOrWhiteSpace(FirstName);
        bool isnullLastName = string.IsNullOrWhiteSpace(LastName);
        bool isnullNationalCode = string.IsNullOrWhiteSpace(NationalCode);
        if(isnullFirstName == true || isnullLastName == true || isnullNationalCode == true )
        {
            MessageBox.Show("Pplease enter valid data");
        }
    }
}
