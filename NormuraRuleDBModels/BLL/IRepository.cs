using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NormuraRuleDBModels.BLL
{
    public interface IRepository<T>
    {
        /// <summary>
        /// 新增一筆資料
        /// </summary>
        /// <param name="entity"></param>
        int Add(T entity);
        /// <summary>
        /// 刪除一筆資料
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        int Del(T entity);
        /// <summary>
        /// 編輯一筆資料
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        int Edit(T entity);
        /// <summary>
        /// 取得所有資料
        /// </summary>
        /// <returns></returns>
        IQueryable<T> GetAll();
    }
}
