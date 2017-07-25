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
    public class WebapimethodRepository
    {
        private readonly IWebapimethodRepositoryProvider _WebapimethodRepositoryProvider = null;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="$custommessage$RepositoryProvider"></param>
        public WebapimethodRepository(IWebapimethodRepositoryProvider WebapimethodRepositoryProvider)
        {
            if (WebapimethodRepositoryProvider == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "WebapimethodRepositoryProvider"));

            _WebapimethodRepositoryProvider = WebapimethodRepositoryProvider;
        }

        public IEnumerable<Webapimethod> GetAll()
        {
            return _WebapimethodRepositoryProvider.GetAll();
        }
    }
}

