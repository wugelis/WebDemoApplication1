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
    public class SystemmoduleRepository
    {
        private readonly ISystemmoduleRepositoryProvider _SystemmoduleRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public SystemmoduleRepository(ISystemmoduleRepositoryProvider SystemmoduleRepositoryProvider)
        {
            if (SystemmoduleRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "SystemmoduleRepositoryProvider"));

            _SystemmoduleRepositoryProvider = SystemmoduleRepositoryProvider;
        }

        public IEnumerable<Systemmodule> GetAll()
        {
            return _SystemmoduleRepositoryProvider.GetAll();
        }
    }
}

