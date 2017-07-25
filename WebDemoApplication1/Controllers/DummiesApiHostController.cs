using EasyArchitect.BO.ServerComponent;
using EasyArchitect.Web.WebApiHostBase;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Web;
using System.Web.Http;

namespace WebDemoApplication1.Controllers
{
    /// <summary>
    /// EasyArchitect 的 Web PI Service Layer 主要入口
    /// 注意：請不要任意修改 Api Controller 的名稱，若真需要修改，請連同 App_Start 下的 WebApiConfig.cs 中的 Route 設定一起修改。
    /// </summary>
    public class DimercoApiHostController : ApiHostBase
    {
    }
}