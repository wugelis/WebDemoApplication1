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
    /// 資料存取物件 User
    /// </summary>
    public class SqlUserRepositoryProvider : IUserRepositoryProvider
    {
        public int Add(User entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(User), new string[] { "ID" }, "User");
            return obj.UpdateData<User>(entity);

        }

        public int Del(User entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            User delObj = new User() { ID = entity.ID };
            obj.SqlStatement = new SqlGenerator().GetDelete<User>(
                delObj,
                new string[] { "ID" },
                "User");
            return obj.UpdateData<User>(delObj);

        }

        public int Edit(User entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(User), new string[] { "ID" }, "User");
            return obj.UpdateData<User>(entity);
        }

        public IQueryable<User> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(User), "User");
            return obj.GetAll<User>().AsQueryable();

        }
    }
}
