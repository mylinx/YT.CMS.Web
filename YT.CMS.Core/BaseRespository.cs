using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Core
{
    public abstract class BaseRespository<TEntity> : IBaseRepository<TEntity> where TEntity :class
    {
        protected YTDBContext _dbcontext;

        public BaseRespository(string name)
        {
            _dbcontext = new YTDBContext(name);
        }

        private DbSet<TEntity> Entity
        {
            get
            {
                return _dbcontext.Set<TEntity>();
            }
        }


        public void SaveChange()
        {
            _dbcontext.SaveChanges();
        }

        public virtual void Add(TEntity entity)
        {
            Entity.Add(entity);
        }

        public void AddAll(IEnumerable<TEntity> entities)
        {
            Entity.AddRange(entities);
        }

        public void Update(TEntity entity)
        {
            Entity.Attach(entity);
            _dbcontext.Entry(entity).State = EntityState.Modified;
        }

        public void Update(IEnumerable<TEntity> entities)
        {
            foreach (TEntity obj in entities)
            {
                Entity.Attach(obj);
                _dbcontext.Entry(obj).State = EntityState.Modified;
            }
        }

        public bool Delete(string ID)
        {
            TEntity entity = Entity.Find(ID);
            if (entity == null)
            {
                return false;
            }
            Entity.Remove(entity);
            return true;
        }

        public void Delete(TEntity entity)
        {
            Entity.Remove(entity);
        }

        public void Delete(Expression<Func<TEntity, bool>> where)
        {
            IEnumerable<TEntity> objects = Entity.Where(where).AsEnumerable();
            DeleteAll(objects);
        }

        public void DeleteAll(IEnumerable<TEntity> entities)
        {
            Entity.RemoveRange(entities);
        }

        public TEntity GetById(string id)
        {
            return Entity.Find(id);
        }

        public TEntity Get(Expression<Func<TEntity, bool>> where)
        { 
            return Entity.Where(where).FirstOrDefault();
        }

        public IEnumerable<TEntity> GetAll()
        {
            return Entity;
        }

        public IEnumerable<TEntity> GetMany(Expression<Func<TEntity, bool>> where)
        {
            return Entity.Where(where);
        }

        /// <summary>
        /// 这个懒加载模式还没实现
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TEntity> GetAllLazy()
        {  
            return GetAll();
        }
    }
}
