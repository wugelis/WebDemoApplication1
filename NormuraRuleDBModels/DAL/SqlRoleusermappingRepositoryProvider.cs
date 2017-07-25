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
    /// 資料存取物件 Roleusermapping
    /// </summary>
    public class SqlRoleusermappingRepositoryProvider : IRoleusermappingRepositoryProvider
    {
        public int Add(Roleusermapping entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Roleusermapping), new string[] { "RoleKey","UserID" }, "Roleusermapping");
            return obj.UpdateData<Roleusermapping>(entity);

        }

        public int Del(Roleusermapping entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Roleusermapping delObj = new Roleusermapping() { RoleKey = entity.RoleKey,UserID = entity.UserID };
            obj.SqlStatement = new SqlGenerator().GetDelete<Roleusermapping>(
                delObj,
                new string[] { "RoleKey","UserID" },
                "Roleusermapping");
            return obj.UpdateData<Roleusermapping>(delObj);

        }

        public int Edit(Roleusermapping entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Roleusermapping), new string[] { "RoleKey","UserID" }, "Roleusermapping");
            return obj.UpdateData<Roleusermapping>(entity);
        }

        public IQueryable<Roleusermapping> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Roleusermapping), "Roleusermapping");
            return obj.GetAll<Roleusermapping>().AsQueryable();

        }
    }
}
