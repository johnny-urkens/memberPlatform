namespace MemberPlatformCore.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string Street { get; set; }
        public string Number { get; set; }
        public string? Box { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        public string Country { get; set; }

        ////public Option AddressType { get; set; }
        public int AddressTypeId { get; set; }
    }
}
