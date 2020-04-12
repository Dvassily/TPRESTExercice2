using Newtonsoft.Json;

namespace TPRESTExercice2Consommation
{
    public class ObservationTimeInfo
    {
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}