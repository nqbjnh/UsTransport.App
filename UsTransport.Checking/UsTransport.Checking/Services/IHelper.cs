namespace UsTransport.Checking.Services
{
    public interface IHelper
    {
        string AppVersion { get; }
        string GetDbPath(string dbName);
    }
}