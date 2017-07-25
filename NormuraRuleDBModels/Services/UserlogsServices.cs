using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class UserlogsService
    {
        private UserlogsRepository _UserlogsRepository = null;

        public UserlogsService(UserlogsRepository UserlogsRepository)
        {
            if (UserlogsRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "UserlogsRepository"));

            _UserlogsRepository = UserlogsRepository;
        }

        public IEnumerable<Userlogs> GetAllUserlogss()
        {
            return _UserlogsRepository.GetAll();
        }

        public int GetAllUserlogsCount()
        {
            return GetAllUserlogss().Count();
        }
    }
}

