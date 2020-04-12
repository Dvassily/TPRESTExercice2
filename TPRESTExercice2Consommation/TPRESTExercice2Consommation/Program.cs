using System;
using System.Threading.Tasks;

namespace TPRESTExercice2Consommation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Récupération des données de température pour la ville de montpellier (latitude=43,6; longitude=3,9)");
            WeatherRealTimeService wrts = new WeatherRealTimeService("bmMuO01TD3gVjiZ1uZX8huRErYA8SQ2u");

            try
            {
                Task<RealTimeResponse> task = wrts.GetAsync(43.6, 3.9);
                RealTimeResponse response = task.Result;

                Console.WriteLine(string.Format("Température = {0}°{1}", response.Temperature.Value, response.Temperature.Units));
                Console.ReadLine();
            } catch (WeatherRealTimeException e)
            {
                Console.WriteLine("error : " + e.Message);
            }
        }
    }
}
