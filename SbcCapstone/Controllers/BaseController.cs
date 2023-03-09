using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace SbcCapstone.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
        
    }
}
