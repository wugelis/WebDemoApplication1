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
    /// 資料存取物件 Userlogs
    /// </summary>
    public class SqlUserlogsRepositoryProvider : IUserlogsRepositoryProvider
    {
        public int Add(Userlogs entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Userlogs), new string[] { "Id" }, "Userlogs");
            return obj.UpdateData<Userlogs>(entity);

        }

        public int Del(Userlogs entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Userlogs delObj = new Userlogs() { Id = entity.Id };
            obj.SqlStatement = new SqlGenerator().GetDelete<Userlogs>(
                delObj,
                new string[] { "Id" },
                "Userlogs");
            return obj.UpdateData<Userlogs>(delObj);

        }

        public int Edit(Userlogs entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Userlogs), new string[] { "Id" }, "Userlogs");
            return obj.UpdateData<Userlogs>(entity);
        }

        public IQueryable<Userlogs> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Userlogs), "Userlogs");
            return obj.GetAll<Userlogs>().AsQueryable();

        }
    }
}
