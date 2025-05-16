using DotNetCore_Angular_SocialMedia_App.DTOs;
using DotNetCore_Angular_SocialMedia_App.Entities;
using DotNetCore_Angular_SocialMedia_App.Helpers;

namespace DotNetCore_Angular_SocialMedia_App.Interface
{
    public interface IUserRepository
    {
        void Update(AppUser user);
        Task<bool> SaveAllAsync();
        Task<IEnumerable<AppUser>> GetUsersAsync();
        Task<AppUser?> GetUserByIdAsync(int id);
        Task<AppUser?> GetUserByUsernameAsync(string username);
        Task<PagedList<MemberDto>> GetMembersAsync(UserParams userParams);
        Task<MemberDto?> GetMemberAsync(string username);
    }
}
