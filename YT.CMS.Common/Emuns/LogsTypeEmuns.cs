using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Common
{
    public enum LogsTypeEmuns
    {
        [Description("错误类型")]
        Erro = -1,

        [Description("信息类型")]
        Info = 0,

        [Description("警告类型")]
        Warning = 1,

        [Description("其他类型")]
        Other = 2,
    }
}
