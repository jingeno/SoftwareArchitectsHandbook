
using SoftwareArchitectsHandbook.Common;

namespace SoftwareArchitectsHandbook.Chapter09
{
    public class LoggingAccountService : AccountServiceDecorator
    {
        private readonly ILogger _logger;

        public LoggingAccountService(IAccountService accountService,
            ILogger logger)
            : base(accountService)
        {
            _logger = logger;
        }

        public override void Save(IAccount account)
        {
            _accountService.Save(account);
            _logger.Info($"Saved account: {account.Number}");
        }
    }
}
