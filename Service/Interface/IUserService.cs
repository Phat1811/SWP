using MedicalStore.Models;

namespace MedicalStore.Service.Interface
{
    public interface IUserService
    {
        public bool UpdatePasswordHandler(User user);
        public bool UpdateUserInfoHandler(User user);
        public User GetUserById(string id);
    }
}
