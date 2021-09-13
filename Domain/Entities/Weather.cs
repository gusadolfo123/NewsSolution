namespace Domain.Entities
{
    public class Weather 
    {
        public int Id { get; set; }
        public string ObservationTime { get; set; }
        public int Temperature { get; set; }
        public string[] WeatherDescriptions { get; set; }
    }
}
