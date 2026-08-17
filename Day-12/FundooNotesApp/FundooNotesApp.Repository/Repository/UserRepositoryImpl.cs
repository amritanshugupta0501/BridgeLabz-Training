using FundooNotesApp.Models;
using System.Linq;

namespace FundooNotesApp.Repository
{
    public class UserRepositoryImpl : IUserRepository
    {
        private readonly FundooNotesAppDbContext _context;
        public UserRepositoryImpl(FundooNotesAppDbContext context)
        {
            _context = context;
        }
        public User GetUserByEmail(string email)
        {
            return _context.User.FirstOrDefault(user => user.EmailAddress == email);
        }
        public User CreateUser(User newUser)
        {
            _context.User.Add(newUser);
            _context.SaveChanges();
            return newUser;
        }
        public bool UpdatePassword(string email, string newPassword)
        {
            var user = GetUserByEmail(email);
            if (user == null)
            {
                return false;
            }
            user.Password = newPassword;
            _context.User.Update(user);
            _context.SaveChanges();
            return true;
        }
    }
}