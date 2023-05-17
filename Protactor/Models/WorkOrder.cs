using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Protractor.Models
{
    internal class cWorkOrder
    {
        public string WorkOrder { get; set; }
        public string Entry { get; set; }
        public string Description { get; set; }
        public float Amount { get; set; }
    }
}
