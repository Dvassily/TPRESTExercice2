using Newtonsoft.Json;

namespace TPRESTExercice2Consommation
{
    public class TemperatureInfo
    {
        [JsonProperty("value")]
        public int Value { get; set; }

        [JsonProperty("units")]
        public string Units { get; set; }
    }
}