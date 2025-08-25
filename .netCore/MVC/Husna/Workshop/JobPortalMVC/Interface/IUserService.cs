using JobPortalMVC.Models;

namespace JobPortalMVC.Interface
{
    public interface IUserService
    {
        User GetBiId(Guid guid);
    }
}
