using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace TPRESTExercice2Consommation
{
    class RealTimeResponse
    {
        [JsonProperty("lat")]
        public int Latitude { get; set; }

        [JsonProperty("lon")]
        public int Longitude { get; set; }

        [JsonProperty("temp")]
        public TemperatureInfo Temperature {get; set;}

        [JsonProperty("observation_time")]
        public ObservationTimeInfo ObservationTime { get; set; }
    }
}
