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
    /// 資料存取物件 Code
    /// </summary>
    public class SqlCodeRepositoryProvider : ICodeRepositoryProvider
    {
        public int Add(Code entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetInsert(typeof(Code), new string[] {  }, "Code");
            return obj.UpdateData<Code>(entity);

        }

        public int Del(Code entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            Code delObj = new Code() {  };
            obj.SqlStatement = new SqlGenerator().GetDelete<Code>(
                delObj,
                new string[] {  },
                "Code");
            return obj.UpdateData<Code>(delObj);

        }

        public int Edit(Code entity)
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetUpdate(typeof(Code), new string[] {  }, "Code");
            return obj.UpdateData<Code>(entity);
        }

        public IQueryable<Code> GetAll()
        {
            GelisDAL.MSSQLObject obj = new GelisDAL.MSSQLObject(new GelisDAL.DataAccess());
            obj.SqlStatement = new SqlGenerator().GetSelect(typeof(Code), "Code");
            return obj.GetAll<Code>().AsQueryable();

        }
    }
}
