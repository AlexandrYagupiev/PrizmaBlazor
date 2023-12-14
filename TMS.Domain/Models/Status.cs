using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Status
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("stСellsId")]
        public long StСellsId { get; set; }

        [JsonProperty("stTypeCellsId")]
        public long StTypeCellsId { get; set; }

        [JsonProperty("name")]
        public string? Name { get; set; }

        [JsonProperty("displayName")]
        public string? DisplayName { get; set; }

        [JsonProperty("colorHex")]
        public string ColorHex { get; set; }

        [JsonProperty("color")]
        public Color Color { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }
    }

}
