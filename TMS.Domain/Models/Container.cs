using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Container
    {
        public int id { get; set; }
        public int cellIdTo { get; set; }
        public int cellId { get; set; }
        public int defects { get; set; }
        public int zIndex { get; set; }
        public string number { get; set; }
        public int type40or20 { get; set; }
        public object numberType40or20 { get; set; }
        public object owner { get; set; }
        public bool export { get; set; }
        public int weight { get; set; }
        public int capacity { get; set; }
        public bool acep { get; set; }
        public DateTime manufactureDate { get; set; }
        public DateTime inspectionDate { get; set; }
        public object typeContainer { get; set; }
        public object contractor { get; set; }
        public DateTime dateOutPlan { get; set; }
        public bool ourTransport { get; set; }
        public string numberTrainSend { get; set; }
        public object numberPlatformSend { get; set; }
        public bool unparity_side { get; set; }
        public bool empty { get; set; }
        public int acceptanceBidId { get; set; }
        public bool isChanged { get; set; }
    }
}
