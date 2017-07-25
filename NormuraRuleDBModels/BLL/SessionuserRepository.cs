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
    public class SessionuserRepository
    {
        private readonly ISessionuserRepositoryProvider _SessionuserRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public SessionuserRepository(ISessionuserRepositoryProvider SessionuserRepositoryProvider)
        {
            if (SessionuserRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "SessionuserRepositoryProvider"));

            _SessionuserRepositoryProvider = SessionuserRepositoryProvider;
        }

        public IEnumerable<Sessionuser> GetAll()
        {
            return _SessionuserRepositoryProvider.GetAll();
        }
    }
}

