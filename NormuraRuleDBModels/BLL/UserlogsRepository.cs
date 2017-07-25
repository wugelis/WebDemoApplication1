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
    public class UserlogsRepository
    {
        private readonly IUserlogsRepositoryProvider _UserlogsRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public UserlogsRepository(IUserlogsRepositoryProvider UserlogsRepositoryProvider)
        {
            if (UserlogsRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "UserlogsRepositoryProvider"));

            _UserlogsRepositoryProvider = UserlogsRepositoryProvider;
        }

        public IEnumerable<Userlogs> GetAll()
        {
            return _UserlogsRepositoryProvider.GetAll();
        }
    }
}

