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
    public class CodeRepository
    {
        private readonly ICodeRepositoryProvider _CodeRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public CodeRepository(ICodeRepositoryProvider CodeRepositoryProvider)
        {
            if (CodeRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "CodeRepositoryProvider"));

            _CodeRepositoryProvider = CodeRepositoryProvider;
        }

        public IEnumerable<Code> GetAll()
        {
            return _CodeRepositoryProvider.GetAll();
        }
    }
}

