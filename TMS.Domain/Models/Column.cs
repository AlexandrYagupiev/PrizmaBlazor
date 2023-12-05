using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Column
    {
        public int id { get; set; }
        public int size { get; set; }
        public int ownerId { get; set; }
        public List<CellsList> cellsList { get; set; }
        public bool empty { get; set; }
        public int stockId { get; set; }
        public bool isChanged { get; set; }
    }
}
