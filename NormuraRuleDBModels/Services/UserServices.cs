using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class UserService
    {
        private UserRepository _UserRepository = null;

        public UserService(UserRepository UserRepository)
        {
            if (UserRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "UserRepository"));

            _UserRepository = UserRepository;
        }

        public IEnumerable<User> GetAllUsers()
        {
            return _UserRepository.GetAll();
        }

        public int GetAllUserCount()
        {
            return GetAllUsers().Count();
        }
    }
}

