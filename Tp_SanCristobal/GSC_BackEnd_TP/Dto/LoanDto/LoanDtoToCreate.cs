namespace GSC_BackEnd_TP.Dto.LoanDto
{
    public class LoanDtoToCreate
    {
        public int PersonId { get; set; }
        public int ThingId { get; set; }
       
        public DateTime AgreeDate { get; set; }
    }
}
