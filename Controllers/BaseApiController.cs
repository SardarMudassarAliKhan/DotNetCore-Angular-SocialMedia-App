using DotNetCore_Angular_SocialMedia_App.Helpers;
using Microsoft.AspNetCore.Mvc;

namespace DotNetCore_Angular_SocialMedia_App.Controllers
{
    [ServiceFilter(typeof(LogUserActivity))]
    [ApiController]
    [Route("api/[controller]")]
    public class BaseApiController : ControllerBase
    {

    }
}
