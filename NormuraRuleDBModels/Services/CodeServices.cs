using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class CodeService
    {
        private CodeRepository _CodeRepository = null;

        public CodeService(CodeRepository CodeRepository)
        {
            if (CodeRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "CodeRepository"));

            _CodeRepository = CodeRepository;
        }

        public IEnumerable<Code> GetAllCodes()
        {
            return _CodeRepository.GetAll();
        }

        public int GetAllCodeCount()
        {
            return GetAllCodes().Count();
        }
    }
}

