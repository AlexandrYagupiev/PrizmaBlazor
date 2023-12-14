using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class CellsList
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stColumnsId")]
        public int StColumnsId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("stRowId")]
        public int StRowId { get; set; }

        [JsonProperty("stPurposeId")]
        public int StPurposeId { get; set; }

        [JsonProperty("maxFloor")]
        public int MaxFloor { get; set; }

        [JsonProperty("containers")]
        public List<Container> Containers { get; set; }

        [JsonProperty("index")]
        public int Index { get; set; }

        [JsonProperty("issueTodayCount")]
        public string IssueTodayCount { get; set; }

        [JsonProperty("issueTomorrowCount")]
        public string IssueTomorrowCount { get; set; }

        [JsonProperty("statuses")]
        public List<Status> Statuses { get; set; }

        [JsonProperty("purpose")]
        public string Purpose { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }
    }
}
