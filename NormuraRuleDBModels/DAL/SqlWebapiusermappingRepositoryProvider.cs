using GelisDAL = GelisFrameworks.Data.DAL;
using GelisFrameworks.Data.Sql.SqlHelper;
using NormuraRuleDBModels.BLL;
using NormuraRuleEntties.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.DAL
{
    /// <summary>
    /// 資料存取物件 Webapiusermapping
    /// </summary>
    public class SqlWebapiusermappingRepositoryProvider : IWebapiusermappingRepositoryProvider
    {
        public int Add(Webapiusermapping entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Webapiusermapping), new string[] { "MethodName","ModuleName","RoleKey","UserID" }, "Webapiusermapping");
            return obj.UpdateData<Webapiusermapping>(entity);

        }

        public int Del(Webapiusermapping entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Webapiusermapping delObj = new Webapiusermapping() { MethodName = entity.MethodName,ModuleName = entity.ModuleName,RoleKey = entity.RoleKey,UserID = entity.UserID };
            obj.SqlStatement = new SqlGenerator().GetDelete<Webapiusermapping>(
                delObj,
                new string[] { "MethodName","ModuleName","RoleKey","UserID" },
                "Webapiusermapping");
            return obj.UpdateData<Webapiusermapping>(delObj);

        }

        public int Edit(Webapiusermapping entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Webapiusermapping), new string[] { "MethodName","ModuleName","RoleKey","UserID" }, "Webapiusermapping");
            return obj.UpdateData<Webapiusermapping>(entity);
        }

        public IQueryable<Webapiusermapping> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Webapiusermapping), "Webapiusermapping");
            return obj.GetAll<Webapiusermapping>().AsQueryable();

        }
    }
}
