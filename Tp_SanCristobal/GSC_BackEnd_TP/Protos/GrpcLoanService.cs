using AutoMapper;
using Grpc.Core;
using GSC_BackEnd_TP.Dto.LoanDto;
using GSC_BackEnd_TP.Services;
using Google.Protobuf.WellKnownTypes;
using System;

namespace GSC_BackEnd_TP.Protos
{
    public class GrpcLoanService : ProtoLoanService.ProtoLoanServiceBase
    {
        private readonly ILoanService loanService;
        private readonly IMapper mapper;

        public GrpcLoanService(ILoanService loanService, IMapper mapper)
        {
            this.loanService = loanService;
            this.mapper = mapper;
        }


        public override Task<Response> CreateLoan(NewLoan request, ServerCallContext context)
        {
            var loanDto = mapper.Map<LoanDtoToCreate>(request);
            var result = loanService.Create(loanDto);

            return Task.FromResult(
               new Response()
               {
                   Message = result
               }
             ); 
       }



    public override Task<Response> CloseLoan(LoanToClose request, ServerCallContext context)
    {
        var result = loanService.Close(request.Id);

        return Task.FromResult(
            new Response()
            {
                Message = result
            }
        );
    }


    public override async Task<PendingLoans>  GetPendingLoans(Empty request, ServerCallContext context)
    {
            var res = await loanService.GetPendingLoans();
            var response = new PendingLoans() { };
            res.ForEach(l =>
            {
                response.Loans.Add(new PendingLoan
                {
                    Id = l.Id,
                    PersonName = l.Person.Name,
                    PersonPhoneNumber = l.Person.PhoneNumber,
                    ThingDesciption = l.Thing.Description,
                    LoanAgreeDate = Timestamp.FromDateTimeOffset(l.AgreeDate)

                });
            });
        return response;

           
        }
}
}
