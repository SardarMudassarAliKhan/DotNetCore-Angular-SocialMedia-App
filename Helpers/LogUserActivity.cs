using DotNetCore_Angular_SocialMedia_App.Extensions;
using DotNetCore_Angular_SocialMedia_App.Interface;
using Microsoft.AspNetCore.Mvc.Filters;

namespace DotNetCore_Angular_SocialMedia_App.Helpers
{
    public class LogUserActivity : IAsyncActionFilter
    {
        public async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            var resultContext = await next();

            if (!resultContext.HttpContext.User.Identity.IsAuthenticated) return;

            var userId = resultContext.HttpContext.User.GetUserId();
            var repo = resultContext.HttpContext.RequestServices.GetService<IUserRepository>();
            var user = await repo.GetUserByIdAsync(userId);
            if (user == null) return;
            user.LastActive = DateTime.UtcNow;
            await repo.SaveAllAsync();
        }
    }
}
