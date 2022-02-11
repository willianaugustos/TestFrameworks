namespace BusinessLogic;
public class Customer
{
    public string FirstName {get; private set;}
    public string LastName {get; private set;}
    public DateOnly? birthDate {get;private set;}

    public string GetFullName() 
    {
        if (string.IsNullOrEmpty(LastName.Trim()))
        {
            return FirstName.Trim();
        }
        else
        {
            return $"{FirstName.Trim()} {LastName.Trim()}";
        }
    }
    public Customer(string FirstName, string LastName, DateOnly? birthDate = null)
    {
        if (string.IsNullOrEmpty(FirstName))
        throw new ArgumentException("The field FirstName is required");

        this.FirstName = FirstName;
        this.LastName = LastName;
        this.birthDate = birthDate;
    }

   
}
