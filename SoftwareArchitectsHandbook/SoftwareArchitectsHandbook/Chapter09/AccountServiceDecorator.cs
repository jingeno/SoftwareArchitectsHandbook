
namespace SoftwareArchitectsHandbook.Chapter09
{
    public abstract class AccountServiceDecorator : IAccountService
    {
        protected readonly IAccountService _accountService;

        public AccountServiceDecorator(IAccountService accountService)
        {
            _accountService = accountService;
        }

        public virtual void Save(IAccount account)
        {
            _accountService.Save(account);
        }
    }
}
