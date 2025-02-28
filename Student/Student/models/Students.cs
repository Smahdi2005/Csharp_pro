namespace Student.models;

internal class Students : Users
{
    //set contructors//
    public Students(string FirstName, string LastName)
    {
        FirstName = FirstName;
        LastName = LastName;
    }

    public Students(string FirstName, string LastName, string NationalCode): this(FirstName, LastName)
    {
        {
            NationalCode = NationalCode;
            //check that user dont enter null data//

            bool isnullFirstName = string.IsNullOrWhiteSpace(FirstName);
            bool isnullLastName = string.IsNullOrWhiteSpace(LastName);
            bool isnullNationalCode = string.IsNullOrWhiteSpace(NationalCode);
            if (isnullFirstName == true || isnullLastName == true || isnullNationalCode == true)
            {
                MessageBox.Show("Pplease enter valid data");
            }

        }

    }

}
