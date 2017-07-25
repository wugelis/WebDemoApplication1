/* 此範本是由NuGet自動產生的 */
using EasyArchitect.Core;
using EasyArchitect.BO.ServerComponent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using NormuraRuleEntties.Entities;
using NormuraRuleDBModels.Services;
using NormuraRuleDBModels.BLL;
using NormuraRuleDBModels.DAL;

namespace MyDemoBO
{
	/// <summary>
	/// BO Server Component
	/// <summary>
	[WriteLog(UseLogType.ToFileSystem)]
    [WriteExceptionLog(UseLogType.ToEventLog)]
    public class Service : ServerComponentBase
    {
        //請在Login Method裡面撰寫Login邏輯，此名稱與參數不可更改。
        /// <summary>
        /// Login邏輯
        /// </summary>
        /// <param name="UserInfo">使用者相關資訊</param>
        /// <returns></returns>
        [EnabledAnonymous(false)]
        [ExposeWebAPI(true)]
        public bool Login(UserInfo param)
        {
            return true;
        }

        /// <summary>
        /// 基本範例，取得目前時間
        /// </summary>
        /// <param name="param"></param>
        /// <returns></returns>
        [EnabledAnonymous(true), ExposeWebAPI(true)]
        public DateTime GetDateTime(decimal param)
        {
            return DateTime.Now;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        [EnabledAnonymous(true), ExposeWebAPI(true)]
        public IEnumerable<User> GetHumanResources()
        {
            UserService service = new UserService(
                new UserRepository(new SqlUserRepositoryProvider()));

            return service.GetAllUsers();
        }
    }
}