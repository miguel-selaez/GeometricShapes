namespace DevelopmentChallenge.Data
{
    public interface ILanguageManager
    {
        string GetLabel(string key);
        string GetEntity(string key, bool isPlural);
    }
}