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
        public int id { get; set; }
        public int stColumnsId { get; set; }
        public string name { get; set; }
        public int stRowId { get; set; }
        public int stPurposeId { get; set; }
        public int maxFloor { get; set; }
        public List<Container> containers { get; set; }
        public int index { get; set; }
        public string issueTodayCount { get; set; }
        public string issueTomorrowCount { get; set; }
        public List<Status> statuses { get; set; }
        public object purpose { get; set; }
        public bool isChanged { get; set; }
    }
}
