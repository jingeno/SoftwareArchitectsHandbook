using SoftwareArchitectsHandbook.Common;
using System;

namespace SoftwareArchitectsHandbook.Chapter09
{
    public class Order
    {
        private readonly ILogger _logger;
        private readonly ICache _cache;

        public Order(ILogger logger, ICache cache)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));
            if (cache == null)
                throw new ArgumentNullException(nameof(cache));

            _logger = logger;
            _cache = cache;
        }
    }
}
