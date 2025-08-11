using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace DevelopmentChallenge.Data.Services.JsonManager
{
    public abstract class JsonLanguageManager : ILanguageManager
    {
        public List<KeyEntityDto> Entities { get; set; }
        public List<KeyLabelDto> Labels { get; set; }

        public string GetLabel(string key)
        {
            var upperKey = GetUpperKey(key);
            var labelItem = Labels.Find(l => l.Key == upperKey);
            return labelItem != null ? labelItem.Value : upperKey;
        }

        public string GetEntity(string key, bool isPlural)
        {
            var upperKey = GetUpperKey(key);
            var entityItem = Entities.Find(l => l.Key == upperKey);
            return entityItem != null 
                ? isPlural
                    ? entityItem.Entity.Plural
                    : entityItem.Entity.Singular
                : upperKey;
        }
        private static string GetUpperKey(string key)
        {
            if (string.IsNullOrEmpty(key))
                throw new ArgumentException("La clave no puede ser vacía o nula");

            var upperKey = key.ToUpper();
            return upperKey;
        }

        protected static List<KeyEntityDto> GetEntityResource(string fileName)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
            return JsonConvert.DeserializeObject<List<KeyEntityDto>>(File.ReadAllText(path));
        }

        protected static List<KeyLabelDto> GetLabelResource(string fileName)
        {
            var path = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", fileName);
            return JsonConvert.DeserializeObject<List<KeyLabelDto>>(File.ReadAllText(path));
        }
    }
}