using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TMS.Domain.Models
{
    public class StocksList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public int Name { get; set; }

        [JsonProperty("actual")]
        public int Actual { get; set; }

        [JsonProperty("lastUpdate")]
        public string LastUpdate { get; set; }

        [JsonProperty("stocks")]
        public List<Stocks> Stocks { get; set; }

        [JsonProperty("selectedCell")]
        public string SelectedCell { get; set; }

        [JsonProperty("maxFloorEmpty")]
        public int MaxFloorEmpty { get; set; }

        [JsonProperty("maxFloorLoaded")]
        public int MaxFloorLoaded { get; set; }

        [JsonProperty("dayPlannedOutput")]
        public int DayPlannedOutput { get; set; }

        [JsonProperty("innerLoaded")]
        public bool InnerLoaded { get; set; }

        [JsonProperty("richstackers")]
        public List<Richstacker> Richstackers { get; set; }

        [JsonProperty("graphicalObjectsScheme")]
        public List<GraphicalObjectsScheme> GraphicalObjectsScheme { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }

    }
}
