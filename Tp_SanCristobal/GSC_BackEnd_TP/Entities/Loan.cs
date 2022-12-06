namespace GSC_BackEnd_TP.Entities
{
    public class Loan: BaseEntity
    {
        public DateTime CreateDate { get; set; }
        public Thing Thing{ get; set; }
        public Person Person { get; set; } 

        public DateTime AgreeDate { get; set; }
        public DateTime? DateReturnedLoan { get; set; }

        public string Status
        {
            get
            {
                if (DateReturnedLoan is null)
                {
                    if (DateTime.Now <= AgreeDate)
                        return "PENDIENTE_EN_TERMINO";
                    else
                        return "PENDIENTE_DEMORADO";
                }
                else
                {
                    if (DateReturnedLoan <= AgreeDate)
                        return "DEVUELTO_EN_TIEMPO";
                    else
                        return "DEVUELTO_FUERA_DE_TERMINO";
                }
            }
        }

        public void cerrarPrestamo()
        {
            if (!estaDevuelto())
            {
                DateReturnedLoan = DateTime.Now;
            }
        }
        public bool estaDevuelto()
        {
            if (DateReturnedLoan is null)
                return false;
            else
                return true;
        }

       

    }
}
