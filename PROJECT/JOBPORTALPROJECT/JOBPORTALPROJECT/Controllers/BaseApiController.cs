using Microsoft.AspNetCore.Mvc;

namespace JOBPORTALPROJECT.Controllers
{
    [Route("api/v1")]
    public abstract class BaseApiController<T>:ControllerBase
    {
    }
}
