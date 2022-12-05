namespace GSC_BackEnd_TP.Entities
{
    public class Thing : BaseEntity
    {
        public Category? Category { get; set; }

        public int CategoryId { get; set; }

        public DateTime CreateDate { get; set; }

        public string? Description { get; set; }
    }
}
