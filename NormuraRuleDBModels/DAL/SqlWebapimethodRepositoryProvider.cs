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
    /// 資料存取物件 Webapimethod
    /// </summary>
    public class SqlWebapimethodRepositoryProvider : IWebapimethodRepositoryProvider
    {
        public int Add(Webapimethod entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Webapimethod), new string[] { "ID" }, "Webapimethod");
            return obj.UpdateData<Webapimethod>(entity);

        }

        public int Del(Webapimethod entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Webapimethod delObj = new Webapimethod() { ID = entity.ID };
            obj.SqlStatement = new SqlGenerator().GetDelete<Webapimethod>(
                delObj,
                new string[] { "ID" },
                "Webapimethod");
            return obj.UpdateData<Webapimethod>(delObj);

        }

        public int Edit(Webapimethod entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Webapimethod), new string[] { "ID" }, "Webapimethod");
            return obj.UpdateData<Webapimethod>(entity);
        }

        public IQueryable<Webapimethod> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Webapimethod), "Webapimethod");
            return obj.GetAll<Webapimethod>().AsQueryable();

        }
    }
}
