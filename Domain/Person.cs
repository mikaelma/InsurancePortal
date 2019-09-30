namespace Domain
{
    public class Person: IEntityBase
    {
        public string Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string TelephoneNumber { get; set; }
        
        public string SocialSecurityNumber { get; set; }
        public Address Address { get; set; }
    }
}