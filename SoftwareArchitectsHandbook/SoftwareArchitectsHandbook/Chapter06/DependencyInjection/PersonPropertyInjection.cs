using System;

namespace SoftwareArchitectsHandbook.Chapter06.DependencyInjection
{
    public class PersonPropertyInjection
    {
        private IOrgService _orgService;

        public IOrgService OrgService
        {
            get
            {
                if (_orgService == null)
                {
                    // Lazy initialization of default
                    _orgService = new OrgService();
                }
                return _orgService;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException(nameof(value));
                }
                // Only allow dependency to be set once
                if (_orgService != null)
                {
                    throw new InvalidOperationException();
                }
                _orgService = value;
            }
        }
    }
}
