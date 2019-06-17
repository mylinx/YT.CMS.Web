using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Core
{

    /// <summary>
    /// 该接口可补充共性的操作函数
    /// </summary>
    /// <typeparam name="T"></typeparam>
   public interface IBaseRepository<T> where T: class
    {

        void SaveChange();
        /// <summary>
        /// 增加实体
        /// </summary>
        /// <param name="entity"></param>
        void Add(T entity);

        /// <summary>
        /// 批量增加
        /// </summary>
        /// <param name="entities"></param>
        void AddAll(IEnumerable<T> entities);

        /// <summary>
        /// 更新实体
        /// </summary>
        /// <param name="entity"></param>
        void Update(T entity);

        /// <summary>
        /// 批量更新
        /// </summary>
        /// <param name="entity"></param>
        void Update(IEnumerable<T> entities);

        /// <summary>
        /// 根据ID删除
        /// </summary>
        /// <param name="ID"></param>
        bool Delete(string ID);


        /// <summary>
        /// 删除实体
        /// </summary>
        /// <param name="entity"></param>
        void Delete(T entity);

        /// <summary>
        /// 条件删除
        /// </summary>
        /// <param name="where"></param>
        void Delete(Expression<Func<T, bool>> where);


        /// <summary>
        /// 批量删除
        /// </summary>
        /// <param name="entities"></param>
        void DeleteAll(IEnumerable<T> entities);
         

        /// <summary>
        /// 根据ID获取实体
        /// </summary>
        /// <param name="Id"></param>
        /// <returns></returns>
        T GetById(string Id);

        /// <summary>
        /// 根据条件获取第一条数据
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        T Get(Expression<Func<T, bool>> where);

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAll();

        /// <summary>
        /// 条件查询
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        IEnumerable<T> GetMany(Expression<Func<T, bool>> where);

        /// <summary>
        /// 懒加载
        /// </summary>
        /// <returns></returns>
        IEnumerable<T> GetAllLazy();
    }
}
