using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class RoleusermappingService
    {
        private RoleusermappingRepository _RoleusermappingRepository = null;

        public RoleusermappingService(RoleusermappingRepository RoleusermappingRepository)
        {
            if (RoleusermappingRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "RoleusermappingRepository"));

            _RoleusermappingRepository = RoleusermappingRepository;
        }

        public IEnumerable<Roleusermapping> GetAllRoleusermappings()
        {
            return _RoleusermappingRepository.GetAll();
        }

        public int GetAllRoleusermappingCount()
        {
            return GetAllRoleusermappings().Count();
        }
    }
}

