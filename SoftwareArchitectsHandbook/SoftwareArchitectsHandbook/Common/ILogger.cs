namespace SoftwareArchitectsHandbook.Common
{
    public interface ILogger
    {
        void Fatal(string message);
        void Error(string message);
        void Warn(string message);
        void Info(string message);
        void Debug(string message);
        void Trace(string message);
    }
}