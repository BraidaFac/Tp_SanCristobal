using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.Dto.ThingDto
{
    public class ThingDtoToCreate
    {
        public string Description { get; set; }

        public Category Category { get; set; }
    }
}
