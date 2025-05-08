using System.Security.Claims;

namespace DotNetCore_Angular_SocialMedia_App.Extensions
{
    public static class ClaimsPrincipleExtensions
    {
        public static string GetUsername(this ClaimsPrincipal user)
        {
            var username = user.FindFirstValue(ClaimTypes.NameIdentifier)
                ?? throw new Exception("Cannot get username from token");

            return username;
        }
    }

}
