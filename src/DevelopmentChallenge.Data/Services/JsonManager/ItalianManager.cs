namespace DevelopmentChallenge.Data.Services.JsonManager
{
    public class ItalianManager : JsonLanguageManager
    {
        public ItalianManager()
        {
            Entities = GetEntityResource("ItalianEntities.json");
            Labels = GetLabelResource("ItalianLabels.json");
        }
    }
}