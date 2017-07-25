using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.BLL
{
    /// <summary>
    /// 
    /// </summary>
    public class UserRepository
    {
        private readonly IUserRepositoryProvider _UserRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public UserRepository(IUserRepositoryProvider UserRepositoryProvider)
        {
            if (UserRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "UserRepositoryProvider"));

            _UserRepositoryProvider = UserRepositoryProvider;
        }

        public IEnumerable<User> GetAll()
        {
            return _UserRepositoryProvider.GetAll();
        }
    }
}

