namespace Domain
{
    public class Address: IEntityBase
    {
        public string Id { get; set; }

        public string StreetNameAndNumber { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
    }
}