namespace GSC_BackEnd_TP.DataAccess
{
    public interface IUnitOfWork
    {
        IThingRepository ThingRepository { get; }
        IPersonRepository PersonRepository { get; }
        ILoanRepository LoanRepository { get; }
        ICategoryRepository CategoryRepository { get; }
        IAddressRepository AddressRepository { get; }
        int Complete();
    }
}
