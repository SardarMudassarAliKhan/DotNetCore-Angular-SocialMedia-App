using DotNetCore_Angular_SocialMedia_App.Entities;

namespace DotNetCore_Angular_SocialMedia_App.Interface
{
    public interface ITokenService
    {
        string CreateToken(AppUser user);
    }
}
