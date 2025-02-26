namespace Student.models;

internal class Students : Users
{
    //set contructors//
    public Students(string firstName, string lastName)
    {
        firstName = FirstName;
        lastName = LastName;
    }

    public Students(string firstName, string lastName, string nationalcode) : this(firstName, lastName)
    {
        {
            nationalcode = Nationalcode;
            //check that user dont enter null data//
            if(firstName==null || lastName==null || nationalcode== null)
            {
                MessageBox.Show("Please enter valid data");
            }

        }

    }

}
