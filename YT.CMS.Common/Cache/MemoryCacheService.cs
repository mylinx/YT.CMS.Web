using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Caching;
using System.Collections.Specialized;

namespace YT.CMS.Common
{ 
    /// <summary>
    /// 缓存接口实现
    /// </summary>
    public class MemoryCacheService : ICacheService
    {
        protected MemoryCache _cache;

        public MemoryCacheService(string name)
        {
            _cache = new MemoryCache(name);
        }

        public MemoryCacheService(string name,NameValueCollection config=null)
        {
            _cache = new MemoryCache(name, config);
        }

        public bool Add(string key, object value, int ExpirtionTime = 20)
        {
            if (!string.IsNullOrEmpty(key))
            {
                _cache.Set(key, value , DateTimeOffset.Now.AddMinutes(ExpirtionTime));
            }
            return true;
        }

        public bool Remove(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return false;
            }
            if (Exists(key))
            {
                _cache.Remove(key);
                return true;
            }
            return false;
        }
         
        public string GetValue(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return null;
            }
            if (Exists(key))
            {
                return _cache.Get(key).ToString();
            }
            return null;
        }
         
        public bool Exists(string key)
        {
            if (string.IsNullOrEmpty(key))
            {
                return false;
            }

            return _cache.Contains(key);
        }
         
    }
}
