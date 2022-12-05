namespace GSC_BackEnd_TP.Entities
{
    public class Person : BaseEntity
    {
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public IList<Loan> Loans  { get; set; }
        public Address Address { get; set; }
    }
}
