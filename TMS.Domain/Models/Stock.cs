using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Stocks
    {
        [JsonProperty("id")]
        public int Id { get; set; }

        [JsonProperty("stSchemeId")]
        public int StSchemeId { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("shortName")]
        public string ShortName { get; set; }

        [JsonProperty("positionX")]
        public int PositionX { get; set; }

        [JsonProperty("positionY")]
        public int PositionY { get; set; }

        [JsonProperty("visibility")]
        public int Visibility { get; set; }

        [JsonProperty("orientation")]
        public int Orientation { get; set; }

        [JsonProperty("topAccess")]
        public int TopAccess { get; set; }

        [JsonProperty("bottomAccess")]
        public int BottomAccess { get; set; }

        [JsonProperty("customs")]
        public int Customs { get; set; }

        [JsonProperty("onlyEmpty")]
        public int OnlyEmpty { get; set; }

        [JsonProperty("reverseRow")]
        public int ReverseRow { get; set; }

        [JsonProperty("reverseColumn")]
        public int ReverseColumn { get; set; }

        [JsonProperty("colorCountRowsUp")]
        public int ColorCountRowsUp { get; set; }

        [JsonProperty("visibilityNameStart")]
        public bool VisibilityNameStart { get; set; }

        [JsonProperty("visibilityNameEnd")]
        public bool VisibilityNameEnd { get; set; }

        [JsonProperty("surfaceNumber")]
        public int SurfaceNumber { get; set; }

        [JsonProperty("stockType")]
        public string StockType { get; set; }

        [JsonProperty("rotation")]
        public int Rotation { get; set; }

        [JsonProperty("columns")]
        public List<Column> Columns { get; set; }

        [JsonProperty("rows")]
        public List<Row> Rows { get; set; }

        [JsonProperty("cellForSelect")]
        public object CellForSelect { get; set; }

        [JsonProperty("subjectDeletion")]
        public bool SubjectDeletion { get; set; }

        [JsonProperty("columnsForRemove")]
        public List<object> ColumnsForRemove { get; set; }

        [JsonProperty("rowsForRemove")]
        public List<object> RowsForRemove { get; set; }

        [JsonProperty("isChanged")]
        public bool IsChanged { get; set; }
    }
}
