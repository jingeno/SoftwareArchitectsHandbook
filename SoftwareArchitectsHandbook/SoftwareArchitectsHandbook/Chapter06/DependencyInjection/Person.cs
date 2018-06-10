using SoftwareArchitectsHandbook.Common;
using System;

namespace SoftwareArchitectsHandbook.Chapter06.DependencyInjection
{
    public class Person
    {
        private readonly ILogger _logger;
        private readonly IOrgService _orgService;

        // Dependencies are injected via the constructor
        public Person(ILogger logger, IOrgService orgService)
        {
            if (logger == null)
                throw new ArgumentNullException(nameof(logger));
            if (orgService == null)
                throw new ArgumentNullException(nameof(orgService));

            _logger = logger;
            _orgService = orgService;
        }
    }
}
