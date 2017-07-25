using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class SystemroleService
    {
        private SystemroleRepository _SystemroleRepository = null;

        public SystemroleService(SystemroleRepository SystemroleRepository)
        {
            if (SystemroleRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "SystemroleRepository"));

            _SystemroleRepository = SystemroleRepository;
        }

        public IEnumerable<Systemrole> GetAllSystemroles()
        {
            return _SystemroleRepository.GetAll();
        }

        public int GetAllSystemroleCount()
        {
            return GetAllSystemroles().Count();
        }
    }
}

