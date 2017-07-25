using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class WebapiusermappingService
    {
        private WebapiusermappingRepository _WebapiusermappingRepository = null;

        public WebapiusermappingService(WebapiusermappingRepository WebapiusermappingRepository)
        {
            if (WebapiusermappingRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "WebapiusermappingRepository"));

            _WebapiusermappingRepository = WebapiusermappingRepository;
        }

        public IEnumerable<Webapiusermapping> GetAllWebapiusermappings()
        {
            return _WebapiusermappingRepository.GetAll();
        }

        public int GetAllWebapiusermappingCount()
        {
            return GetAllWebapiusermappings().Count();
        }
    }
}

