namespace GSC_BackEnd_TP.Entities
{
    public class Loan: BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public Thing? Thing{ get; set; }
        public Person? Person { get; set; } 
        public string? Status { get; set; }  

    }
}
