using GSC_BackEnd_TP.Entities;

namespace GSC_BackEnd_TP.Dto
{
    public class PersonDto
    {   
             public int Id { get; set; }
            public string Name { get; set; }
            public string PhoneNumber { get; set; }
            public string Email { get; set; }

            public Address Address { get; set; }
    }
}
