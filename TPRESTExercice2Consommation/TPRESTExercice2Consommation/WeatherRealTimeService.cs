using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TPRESTExercice2Consommation
{

    class WeatherRealTimeService
    {
        private const string WeatherRealTimeUrl = "https://api.climacell.co/v3/weather/realtime";
        private HttpClient _client;

        public WeatherRealTimeService(string apiKey)
        {
            _client = new HttpClient();
            _client.DefaultRequestHeaders.Add("apikey", apiKey);
        }

        public async Task<RealTimeResponse> GetAsync(double latitude, double longitude)
        {
            var uri = string.Format(WeatherRealTimeUrl + "?lat={0}&lon={1}&unit_system=si&fields=temp", latitude, longitude);
            var response = await _client.GetAsync(uri);
            
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();

                return JsonConvert.DeserializeObject<RealTimeResponse>(content);
            }

            throw new WeatherRealTimeException(response.StatusCode, response.ReasonPhrase);
        }
    }
}
