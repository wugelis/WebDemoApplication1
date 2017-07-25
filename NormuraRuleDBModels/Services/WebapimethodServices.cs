using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.Services
{
    public class WebapimethodService
    {
        private WebapimethodRepository _WebapimethodRepository = null;

        public WebapimethodService(WebapimethodRepository WebapimethodRepository)
        {
            if (WebapimethodRepository == null)
                throw new ArgumentNullException(string.Format("參數名稱 {0} 不可以是 null.", "WebapimethodRepository"));

            _WebapimethodRepository = WebapimethodRepository;
        }

        public IEnumerable<Webapimethod> GetAllWebapimethods()
        {
            return _WebapimethodRepository.GetAll();
        }

        public int GetAllWebapimethodCount()
        {
            return GetAllWebapimethods().Count();
        }
    }
}

