using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Caching.Memory;
using System.Data;

namespace Formu_Listos_ATM.Functions
{
    //@inject IMemoryCache _memoryCache

     
    public class UserFunctions
    {
        private readonly IMemoryCache _memoryCache;

        public UserFunctions(IMemoryCache memoryCache)
        {
            _memoryCache = memoryCache;
        }
        public bool UserValid()
        {
            if (_memoryCache.Get("Name") != null)
            {
                var userValidated = (bool)_memoryCache.Get("UserValidated") ;
                if (userValidated) { 
                    return true ;
                }
            }
            return false;
        }
    }
}
