using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TMS.Domain.Models
{
    public class Color
    {
        public int r { get; set; }
        public int g { get; set; }
        public int b { get; set; }
        public int a { get; set; }
        public bool isKnownColor { get; set; }
        public bool isEmpty { get; set; }
        public bool isNamedColor { get; set; }
        public bool isSystemColor { get; set; }
        public string name { get; set; }
    }
}
