using System;

namespace SoftwareArchitectsHandbook.Chapter06.SingleResponsibilityPrinciple
{
    public class EmailService : IEmailService
    {
        public SendEmailResponse SendEmail(SendEmailRequest request)
        {
            if (request == null)
                throw new ArgumentNullException(nameof(request));

            SendEmailResponse response = null;

            try
            {
                // Logic to send email


                // Log info about sent email
                LogInfo("Some info message");
            }
            catch (Exception ex)
            {
                // Log details about error
                LogError("Some error message");
            }

            return response;
        }

        private void LogInfo(string message)
        {
            // Logic to write to file system for logging
        }

        private void LogError(string message)
        {
            // Logic to write to file system for logging
        }
    }
}
