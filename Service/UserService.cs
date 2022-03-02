using MedicalStore.DAO.Interface;
using MedicalStore.Models;
using MedicalStore.Service.Interface;
using MedicalStore.Utils;

namespace MedicalStore.Service
{
    public class UserService: IUserService
    {
        private readonly DBContext DBContext;
        private readonly IUserRepository UserRepository;
        private readonly IAuthService AuthService;

        public UserService(DBContext dBContext, IUserRepository userRepository, IAuthService authService)
        {
            this.DBContext = dBContext;
            this.UserRepository = userRepository;
            this.AuthService = authService;
        }

        public User GetUserById(string id)
        {
            return this.UserRepository.GetUserById(id);
        }

        public bool UpdatePasswordHandler(User user)
        {
            return this.UserRepository.UpdatePasswordHandler(user);
        }

        public bool UpdateUserInfoHandler(User user)
        {
            return this.UserRepository.UpdateUserInfoHandler(user);
        }
    }
}
