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
    public class WebapiusermappingRepository
    {
        private readonly IWebapiusermappingRepositoryProvider _WebapiusermappingRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public WebapiusermappingRepository(IWebapiusermappingRepositoryProvider WebapiusermappingRepositoryProvider)
        {
            if (WebapiusermappingRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "WebapiusermappingRepositoryProvider"));

            _WebapiusermappingRepositoryProvider = WebapiusermappingRepositoryProvider;
        }

        public IEnumerable<Webapiusermapping> GetAll()
        {
            return _WebapiusermappingRepositoryProvider.GetAll();
        }
    }
}

