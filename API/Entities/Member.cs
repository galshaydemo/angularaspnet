namespace API.Entities
{
    public class Member(
        string firstName,
        string lastName
        )
    {
        public int  Id { get; set;}
        public string FirstName { get; set; } = firstName;


        public string LastName { get; set; } = lastName;

        public string FullName => FirstName + ' ' + LastName;
    }
}
