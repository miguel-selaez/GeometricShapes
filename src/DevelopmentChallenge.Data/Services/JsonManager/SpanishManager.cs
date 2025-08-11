namespace DevelopmentChallenge.Data.Services.JsonManager
{
    public class SpanishManager : JsonLanguageManager
    {
        public SpanishManager()
        {
            Entities = GetEntityResource("SpanishEntities.json");
            Labels = GetLabelResource("SpanishLabels.json");
        }
    }
}