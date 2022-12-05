namespace GSC_BackEnd_TP.Entities
{
    public class Category : BaseEntity
    {   

      public IList<Thing>? Things { get; set; }
      public DateTime CreateDate { get; set; }
      public string Description { get; set; }
    }
}
