using SoftwareArchitectsHandbook.Common;
using System;

namespace SoftwareArchitectsHandbook.Chapter06.SingleResponsibilityPrinciple
{
    public class RefactoredEmailService : IEmailService
    {
        private readonly ILogger _logger;

        public RefactoredEmailService(ILogger logger)
        {
            if (_logger == null)
                throw new ArgumentNullException(nameof(logger));

            _logger = logger;
        }

        public SendEmailResponse SendEmail(SendEmailRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            SendEmailResponse response = null;

            try
            {
                // Logic to send email


                // Log info about sent email
                _logger.Info("Info message");
            }
            catch (Exception ex)
            {
                // Log details about error
                _logger.Error($"Error message: {ex.Message}");
            }

            return response;
        }
    }
}
