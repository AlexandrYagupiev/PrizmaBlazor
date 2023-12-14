using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TMS.Domain.Models
{
    public class Richstacker
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("name")]
        public int Name { get; set; }

        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("fieldAdmin")]
        public string FieldAdmin { get; set; }

        [JsonProperty("gpsImei")]
        public string GpsImei { get; set; }

    }
}
