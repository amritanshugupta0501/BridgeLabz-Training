using FundooNotesApp.Models;

namespace FundooNotesApp.Repository
{
    public interface IUserRepository
    {
        User GetUserByEmail(string emailAddress);
        User CreateUser(User user);
        bool UpdatePassword(string emailAddress, string newPassword);
    }
}