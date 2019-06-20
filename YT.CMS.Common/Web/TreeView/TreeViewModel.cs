using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Common
{
    public class TreeViewModel
    {

        public string ID { get; set; }
        public string ParentID { get; set; }
        public string Text { get; set; }
        public string Value { get; set; }
        public int? CheckState { get; set; }
        public bool ShowCheck { get; set; }
        public bool Complete { get; set; }
        public bool IsExpand { get; set; }
        public bool HasChildren { get; set; }
        public string Img { get; set; }
        public string Title { get; set; }
    }
}
