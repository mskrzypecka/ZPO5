using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZPO5.Interfaces;

namespace ZPO5
{
    public class Cache : ICacheStore
    {
        Dictionary<string, string> cache;

        public Cache()
        {
            cache = new Dictionary<string, string>();
        }

        public virtual bool AddOrUpdate(string id, string message)
        {
            if (cache.ContainsKey(id))
                cache[id] = message;
            else
                cache.Add(id, message);
            
            return true;
        }

        public virtual string Get(string id) => cache[id];
    }
}
