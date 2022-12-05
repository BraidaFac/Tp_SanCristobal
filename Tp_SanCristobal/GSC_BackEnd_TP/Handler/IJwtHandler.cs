
using GSC_BackEnd_TP.Services;

namespace GSC_BackEnd_TP.Handler
{
    public interface IJwtHandler
    {
        string GenerateToken(User user);
    }
}
