﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Caching.Distributed;

namespace Sky.Common
{ 
    /// <summary>
    /// 缓存接口实现
    /// </summary>
    public class MemoryCacheService : ICacheService
    {
        protected IMemoryCache _cache;

        public MemoryCacheService(IMemoryCache cache)
        {
            _cache = cache;
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

            return _cache.TryGetValue(key, out object cache);
        }
         
    }
}
