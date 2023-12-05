using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Status
    {
        public int id { get; set; }
        public int stellsId { get; set; }
        public int stTypeCellsId { get; set; }
        public string name { get; set; }
        public string displayName { get; set; }
        public string colorHex { get; set; }
        public Color color { get; set; }
        public bool isChanged { get; set; }
    }

}
