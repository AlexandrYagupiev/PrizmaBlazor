using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Stocks
    {
        public int id { get; set; }
        public int stSchemeId { get; set; }
        public string name { get; set; }
        public string shortName { get; set; }
        public string positionX { get; set; }
        public string positionY { get; set; }
        public int visibility { get; set; }
        public int orientation { get; set; }
        public int topAccess { get; set; }
        public int bottomAccess { get; set; }
        public int customs { get; set; }
        public int onlyEmpty { get; set; }
        public int reverseRow { get; set; }
        public int reverseColumn { get; set; }
        public int colorCountRowsUp { get; set; }
        public bool visibilityNameStart { get; set; }
        public bool visibilityNameEnd { get; set; }
        public int surfaceNumber { get; set; }
        public string stockType { get; set; }
        public int rotation { get; set; }
        public List<Column> columns { get; set; }
        public List<Row> rows { get; set; }
        public object cellForSelect { get; set; }
        public bool subjectDeletion { get; set; }
        public List<object> columnsForRemove { get; set; }
        public List<object> rowsForRemove { get; set; }
        public bool isChanged { get; set; }
    }
}
