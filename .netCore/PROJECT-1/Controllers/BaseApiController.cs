using Microsoft.AspNetCore.Mvc;

namespace JobPortalApp.API
{
    [ApiController]
    [Route("api/[controller]")]
    public abstract class BaseApiController<T> : ControllerBase
    {
        // You can put shared methods or properties here if needed
        // For example, get logged-in user ID, common response wrappers, etc.
    }
}
