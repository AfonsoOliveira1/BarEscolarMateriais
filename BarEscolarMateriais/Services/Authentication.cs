using BarEscolarMateriais.Models;
using BarEscolarMateriais.Services;
using System.Data;
using Microsoft.AspNetCore.Identity;
namespace BarEscolarMateriais.Services

{
    public class Authentication
    {
        private dbEscolaAferContext _context;
        private PasswordHasher<User> _passwordHasher;
        private User? _currentuser;

        public Authentication()
        {
            _context = new dbEscolaAferContext();
            _passwordHasher = new PasswordHasher<User>();
        }
        public User? FinByLogin(string login)
        {
            if (string.IsNullOrWhiteSpace(login))
                return null;

            return _context.Users.FirstOrDefault(u => u.UserName.Equals(login) || u.Email.Equals(login));
        }
        public User CurrentUser() => _currentuser;

        public bool Login(string username, string password)
        {
            User user = FinByLogin(username);
            if (user == null) return false;

            PasswordVerificationResult result = _passwordHasher.VerifyHashedPassword(user, user.Passwordhash, password);
            if (result == PasswordVerificationResult.Success)
            {
                _currentuser = user;
                return true;
            }
            return false;
        }

        public void Logout()
        {
            _currentuser = null;
        }
    }
}