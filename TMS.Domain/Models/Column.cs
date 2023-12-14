using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Column
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("size")]
        public int Size { get; set; }

        [JsonProperty("ownerId")]
        public int OwnerId { get; set; }

        [JsonProperty("displayName")]
        public string DisplayName { get; set; }

        [JsonProperty("cellsList")]
        public List<CellsList> CellsList { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("stockId")]
        public int StockId { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }
    }
}
