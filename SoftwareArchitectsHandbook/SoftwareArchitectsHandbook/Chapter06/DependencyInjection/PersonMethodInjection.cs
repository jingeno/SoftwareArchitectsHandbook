using System;

namespace SoftwareArchitectsHandbook.Chapter06.DependencyInjection
{
    public class PersonMethodInjection
    {
        private IOrgService _orgService;

        public void Initialize(IOrgService orgService)
        {
            if (orgService == null)
                throw new ArgumentNullException(nameof(orgService));

            _orgService = orgService;
        }
    }
}
