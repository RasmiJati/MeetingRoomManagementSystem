using MeetingRoomSystem.Models.DTO;

namespace MeetingRoomSystem.Repositories.Abstract
{
    public interface IUserAuthenticationService
    {
        Task<Status> LoginAsync(LoginModel model);
        Task<Status> RegistrationAsync(RegistrationModel model);
        Task LogoutAsyn();

    }
}
