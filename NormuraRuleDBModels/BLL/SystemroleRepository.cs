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
    public class SystemroleRepository
    {
        private readonly ISystemroleRepositoryProvider _SystemroleRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public SystemroleRepository(ISystemroleRepositoryProvider SystemroleRepositoryProvider)
        {
            if (SystemroleRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "SystemroleRepositoryProvider"));

            _SystemroleRepositoryProvider = SystemroleRepositoryProvider;
        }

        public IEnumerable<Systemrole> GetAll()
        {
            return _SystemroleRepositoryProvider.GetAll();
        }
    }
}

