using ARMDataManager.Models;
using System.Threading.Tasks;

namespace ARmDesktopUI.Helpers
{
    public interface IAPIHelper
    {
        Task<AuthenticatedUser> Authenticate(string username, string password);
    }
}