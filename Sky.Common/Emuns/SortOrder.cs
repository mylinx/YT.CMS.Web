﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sky.Common.Emuns
{
    // 摘要: 
    //     指定数据行排序方式。
    public enum SortOrder
    {
        // 摘要: 
        //     默认值。 不指定排序顺序。
        Unspecified = -1,
        //
        // 摘要: 
        //     按升序排序各行。
        Ascending = 0,
        //
        // 摘要: 
        //     按降序排序各行。
        Descending = 1,
    }
}
