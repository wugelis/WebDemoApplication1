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
    public class RoleusermappingRepository
    {
        private readonly IRoleusermappingRepositoryProvider _RoleusermappingRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public RoleusermappingRepository(IRoleusermappingRepositoryProvider RoleusermappingRepositoryProvider)
        {
            if (RoleusermappingRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "RoleusermappingRepositoryProvider"));

            _RoleusermappingRepositoryProvider = RoleusermappingRepositoryProvider;
        }

        public IEnumerable<Roleusermapping> GetAll()
        {
            return _RoleusermappingRepositoryProvider.GetAll();
        }
    }
}

