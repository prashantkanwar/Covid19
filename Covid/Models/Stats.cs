using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Covid.Models
{
    public class Stats
    {
        [JsonPropertyName("TotalConfirmed")]
        public long Confirmed { get; set; }
        [JsonPropertyName("TotalRecovered")]
        public long Recovered { get; set; }
        [JsonPropertyName("TotalDeaths")]
        public long Deaths { get; set; }

    }
}
