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
    /// 資料存取物件 Systemrole
    /// </summary>
    public class SqlSystemroleRepositoryProvider : ISystemroleRepositoryProvider
    {
        public int Add(Systemrole entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Systemrole), new string[] { "ID" }, "Systemrole");
            return obj.UpdateData<Systemrole>(entity);

        }

        public int Del(Systemrole entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Systemrole delObj = new Systemrole() { ID = entity.ID };
            obj.SqlStatement = new SqlGenerator().GetDelete<Systemrole>(
                delObj,
                new string[] { "ID" },
                "Systemrole");
            return obj.UpdateData<Systemrole>(delObj);

        }

        public int Edit(Systemrole entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Systemrole), new string[] { "ID" }, "Systemrole");
            return obj.UpdateData<Systemrole>(entity);
        }

        public IQueryable<Systemrole> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Systemrole), "Systemrole");
            return obj.GetAll<Systemrole>().AsQueryable();

        }
    }
}
