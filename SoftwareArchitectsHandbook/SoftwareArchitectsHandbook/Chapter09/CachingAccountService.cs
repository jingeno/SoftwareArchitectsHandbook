using SoftwareArchitectsHandbook.Common;

namespace SoftwareArchitectsHandbook.Chapter09
{
    public class CachingAccountService : AccountServiceDecorator
    {
        private readonly ICache _cache;

        public CachingAccountService(IAccountService accountService,
            ICache cache)
        : base(accountService)
    {
            _cache = cache;
        }

        public override void Save(IAccount account)
        {
            _accountService.Save(account);
            _cache.Put(account.Number.ToString(), account.Name);
        }
    }
}
