using System;
using System.Collections.Generic;

namespace Demo_NetCoreAngularSql_Docker
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

        public string Summary { get; set; }

        public List<Entity> Entities { get; set; }
    }

    public class Entity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}
