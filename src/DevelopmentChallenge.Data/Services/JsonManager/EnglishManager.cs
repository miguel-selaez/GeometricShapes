namespace DevelopmentChallenge.Data.Services.JsonManager
{
    public class EnglishManager : JsonLanguageManager
    {
        public EnglishManager()
        {
            Entities = GetEntityResource("EnglishEntities.json");
            Labels = GetLabelResource("EnglishLabels.json");
        }
    }
}