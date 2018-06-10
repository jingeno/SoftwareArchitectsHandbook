using SoftwareArchitectsHandbook.Common;
using System;

namespace SoftwareArchitectsHandbook.Chapter06.DependencyInjection
{
    public class Employee : Person
    {
        private readonly ILogger _logger;
        private readonly ICache _cache;

        // Dependencies are injected via the constructor,
        // including the base class
        public Employee(ILogger logger, ICache cache,
            IOrgService orgService)
            : base(logger, orgService)
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
