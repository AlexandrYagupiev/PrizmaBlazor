using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TMS.Domain.Models
{
    public class GraphicalObjectsScheme
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("schemeId")]
        public int SchemeId { get; set; }

        [JsonProperty("width")]
        public int Width { get; set; }

        [JsonProperty("height")]
        public int Height { get; set; }

        [JsonProperty("thicknessLines")]
        public int ThicknessLines { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("positionX")]
        public int PositionX { get; set; }

        [JsonProperty("positionY")]
        public int PositionY { get; set; }

        [JsonProperty("positionTextX")]
        public int PositionTextX { get; set; }

        [JsonProperty("positionTextY")]
        public int PositionTextY { get; set; }

        [JsonProperty("widthTxt")]
        public int WidthTxt { get; set; }

        [JsonProperty("heightTxt")]
        public int HeightTxt { get; set; }

        [JsonProperty("fontSize")]
        public int FontSize { get; set; }

        [JsonProperty("horizontalText")]
        public bool HorizontalText { get; set; }

        [JsonProperty("subjectDeletion")]
        public bool SubjectDeletion { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }
    }
}
