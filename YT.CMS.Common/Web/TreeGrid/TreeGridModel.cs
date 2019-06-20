using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Common
{
    public class TreeGridModel
    {
        public string ID { get; set; }
        public string ParentID { get; set; }
        public string Text { get; set; }
        public bool IsLeaf { get; set; }
        public bool Expanded { get; set; }
        public bool Loaded { get; set; }
        public string EntityJson { get; set; }
    }
}
