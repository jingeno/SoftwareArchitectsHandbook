namespace SoftwareArchitectsHandbook.Common
{
    public interface ICache
    {
        string Get(string v);
        void Put(string v, object p);
    }
}