using System.Linq;
using System.Security.Claims;
using System.Threading;
using System.Web.Http;

namespace AdfsWifSample.Controllers
{
    [Authorize]
    public class ClaimsController : ApiController
    {
        public string GetUserEmail()
        {
            return ((ClaimsPrincipal)Thread.CurrentPrincipal).Claims
                .Single(claim => claim.Issuer == ClaimsHelper.TrustedIssuer && claim.Type == ClaimTypes.Email).Value;
        }
    }
}
