namespace Student.models;

internal class Masters : Users
{
    //set constructors//
    public Masters(string firstName , string lastName) 
    {
        firstName = FirstName;
        lastName = LastName;
        //check that user dont enter null data//
        if (firstName == null || lastName == null)
        {
            MessageBox.Show("please enter valid data");
        }
    }
}
