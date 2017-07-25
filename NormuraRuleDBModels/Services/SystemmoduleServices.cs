using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class SystemmoduleService
    {
        private SystemmoduleRepository _SystemmoduleRepository = null;

        public SystemmoduleService(SystemmoduleRepository SystemmoduleRepository)
        {
            if (SystemmoduleRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "SystemmoduleRepository"));

            _SystemmoduleRepository = SystemmoduleRepository;
        }

        public IEnumerable<Systemmodule> GetAllSystemmodules()
        {
            return _SystemmoduleRepository.GetAll();
        }

        public int GetAllSystemmoduleCount()
        {
            return GetAllSystemmodules().Count();
        }
    }
}

