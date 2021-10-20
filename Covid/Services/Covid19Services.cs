using Covid.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace Covid.Services
{
    public class Covid19Services
    {
        private readonly HttpClient client = new HttpClient();
        public async Task<Stats> GetWorldData()
        {
            var worldDataTask = client.GetStreamAsync("https://api.covid19api.com/world/total");
            var worldData = await JsonSerializer.DeserializeAsync<Stats>(await worldDataTask);
            return worldData;
        }
    }
}
