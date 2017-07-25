using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class SessionuserService
    {
        private SessionuserRepository _SessionuserRepository = null;

        public SessionuserService(SessionuserRepository SessionuserRepository)
        {
            if (SessionuserRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "SessionuserRepository"));

            _SessionuserRepository = SessionuserRepository;
        }

        public IEnumerable<Sessionuser> GetAllSessionusers()
        {
            return _SessionuserRepository.GetAll();
        }

        public int GetAllSessionuserCount()
        {
            return GetAllSessionusers().Count();
        }
    }
}

