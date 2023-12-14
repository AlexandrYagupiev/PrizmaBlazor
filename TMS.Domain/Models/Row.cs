using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Row
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stockId")]
        public int StockId { get; set; }

        [JsonProperty("rowNumber")]
        public int RowNumber { get; set; }

        [JsonProperty("rowName")]
        public string RowName { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }
    }
}
