using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Row
    {
        public int id { get; set; }
        public int stockId { get; set; }
        public int rowNumber { get; set; }
        public string rowName { get; set; }
        public int visibility { get; set; }
        public bool isChanged { get; set; }
    }
}
