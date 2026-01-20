/*
using BarEscolarMateriais.Models;
using BarEscolarMateriais.Services;
using System.Data;
namespace BarEscolarMateriais.Services

{
    public class Authentication
    {
        private dbEscolaAferContext _context;
        private PasswordHasher<Users> _passwordHasher;
        private User _currentuser;

        public Authentication(JsonUserStore userStore)
        {
            m_userStore = userStore;
            _passwordHasher = new PasswordHasher<Users>();
        }
        public Users FinByLogin(string login)
        {
            return m_userStore.FinByLogin(login);
        }
        public Users CurrentUser => _currentuser;

        public bool Login(string username, string password)
        {
            Users user = m_userStore.FinByLogin(username);
            if (user == null) return false;

            PasswordVerificationResult result = _passwordHasher.VerifyHashedPassword(user, user.passwordhash, password);
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

        public void CreateUser(string fullName, string email, string username, string password, UserRole role)
        {
            Users user = new Users
            {
                ID = Guid.NewGuid().ToString(),
                FullName = fullName,
                Email = email,
                UserName = username,
                role = role
            };

            user.passwordhash = _passwordHasher.HashPassword(user, password);
            m_userStore.AddUser(user);
        }


    }
}
*/