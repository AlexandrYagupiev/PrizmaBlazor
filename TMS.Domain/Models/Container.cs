using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Container
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("cellIdTo")]
        public int CellIdTo { get; set; }

        [JsonProperty("cellId")]
        public int CellId { get; set; }

        [JsonProperty("defects")]
        public int Defects { get; set; }

        [JsonProperty("zIndex")]
        public int ZIndex { get; set; }

        [JsonProperty("number")]
        public string Number { get; set; }

        [JsonProperty("type40or20")]
        public int Type40Or20 { get; set; }

        [JsonProperty("numberType40or20")]
        public string NumberType40Or20 { get; set; }

        [JsonProperty("owner")]
        public string Owner { get; set; }

        [JsonProperty("export")]
        public bool Export { get; set; }

        [JsonProperty("weight")]
        public int Weight { get; set; }

        [JsonProperty("capacity")]
        public int Capacity { get; set; }

        [JsonProperty("acep")]
        public bool Acep { get; set; }

        [JsonProperty("manufactureDate")]
        public DateTime ManufactureDate { get; set; }

        [JsonProperty("inspectionDate")]
        public DateTime InspectionDate { get; set; }

        [JsonProperty("typeContainer")]
        public string TypeContainer { get; set; }

        [JsonProperty("contractor")]
        public string Contractor { get; set; }

        [JsonProperty("dateOutPlan")]
        public DateTime DateOutPlan { get; set; }

        [JsonProperty("ourTransport")]
        public bool OurTransport { get; set; }

        [JsonProperty("numberTrainSend")]
        public string NumberTrainSend { get; set; }

        [JsonProperty("numberPlatformSend")]
        public int? NumberPlatformSend { get; set; }

        [JsonProperty("unparity_side")]
        public bool UnparitySide { get; set; }

        [JsonProperty("empty")]
        public bool Empty { get; set; }

        [JsonProperty("acceptanceBidId")]
        public int AcceptanceBidId { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }
    }
}
