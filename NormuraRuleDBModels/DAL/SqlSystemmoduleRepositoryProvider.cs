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
    /// 資料存取物件 Systemmodule
    /// </summary>
    public class SqlSystemmoduleRepositoryProvider : ISystemmoduleRepositoryProvider
    {
        public int Add(Systemmodule entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Systemmodule), new string[] { "ModuleName","RoleKey" }, "Systemmodule");
            return obj.UpdateData<Systemmodule>(entity);

        }

        public int Del(Systemmodule entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Systemmodule delObj = new Systemmodule() { ModuleName = entity.ModuleName,RoleKey = entity.RoleKey };
            obj.SqlStatement = new SqlGenerator().GetDelete<Systemmodule>(
                delObj,
                new string[] { "ModuleName","RoleKey" },
                "Systemmodule");
            return obj.UpdateData<Systemmodule>(delObj);

        }

        public int Edit(Systemmodule entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Systemmodule), new string[] { "ModuleName","RoleKey" }, "Systemmodule");
            return obj.UpdateData<Systemmodule>(entity);
        }

        public IQueryable<Systemmodule> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Systemmodule), "Systemmodule");
            return obj.GetAll<Systemmodule>().AsQueryable();

        }
    }
}
