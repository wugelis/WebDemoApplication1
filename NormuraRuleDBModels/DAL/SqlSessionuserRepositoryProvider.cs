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
    /// 資料存取物件 Sessionuser
    /// </summary>
    public class SqlSessionuserRepositoryProvider : ISessionuserRepositoryProvider
    {
        public int Add(Sessionuser entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Sessionuser), new string[] { "ID" }, "Sessionuser");
            return obj.UpdateData<Sessionuser>(entity);

        }

        public int Del(Sessionuser entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Sessionuser delObj = new Sessionuser() { ID = entity.ID };
            obj.SqlStatement = new SqlGenerator().GetDelete<Sessionuser>(
                delObj,
                new string[] { "ID" },
                "Sessionuser");
            return obj.UpdateData<Sessionuser>(delObj);

        }

        public int Edit(Sessionuser entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Sessionuser), new string[] { "ID" }, "Sessionuser");
            return obj.UpdateData<Sessionuser>(entity);
        }

        public IQueryable<Sessionuser> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Sessionuser), "Sessionuser");
            return obj.GetAll<Sessionuser>().AsQueryable();

        }
    }
}
