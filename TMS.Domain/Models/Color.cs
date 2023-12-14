using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Color
    {
        [JsonProperty("r")]
        public long R { get; set; }

        [JsonProperty("g")]
        public long G { get; set; }

        [JsonProperty("b")]
        public long B { get; set; }

        [JsonProperty("a")]
        public long A { get; set; }

        [JsonProperty("isKnownColor")]
        public bool IsKnownColor { get; set; }

        [JsonProperty("isEmpty")]
        public bool IsEmpty { get; set; }

        [JsonProperty("isNamedColor")]
        public bool IsNamedColor { get; set; }

        [JsonProperty("isSystemColor")]
        public bool IsSystemColor { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
