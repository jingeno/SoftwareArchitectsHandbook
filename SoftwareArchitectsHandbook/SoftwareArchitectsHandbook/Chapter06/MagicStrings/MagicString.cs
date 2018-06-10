using SoftwareArchitectsHandbook.Common;
using System;

namespace SoftwareArchitectsHandbook.Chapter06.MagicStrings
{
    public class MagicString
    {
        private ICache _cache;

        public MagicString(ICache cache)
        {
            _cache = cache;
        }
        
        public string GetFilePath()
        {
            string result = _cache.Get("FilePathCacheKey");

            if (string.IsNullOrEmpty(result))
            {
                _cache.Put("FilePathCacheKey", DetermineFilePath());
                result = _cache.Get("FilePathCacheKey");
            }

            return result;
        }

        public string DetermineFilePath()
        {
            throw new NotImplementedException();
        }
    }
}
