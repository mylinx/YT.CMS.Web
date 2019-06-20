using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Common
{
    public class TreeModel
    {
        public string id { get; set; }
        public string text { get; set; }
        public int? layers { get; set; }
        public string urladdress { get; set; }
        public string icon { get; set; }
        public int? sortcode { get; set; }
        public bool? enabledmark { get; set; }
        public object children { get; set; }
    }
}
