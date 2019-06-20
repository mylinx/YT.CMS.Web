using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YT.CMS.Common
{
    public class AjaxResult
    {
        /// <summary>
        /// 操作是否成功
        /// </summary>
        public bool isvalue { get; set; }

        /// <summary>
        /// 操作结果类型
        /// </summary>
        public object state { get; set; }

        /// <summary>
        /// 操作消息内容
        /// </summary>
        public string errormessage { get; set; }

        /// <summary>
        /// 操作返回数据
        /// </summary>
        public object rows { get; set; }

        /// <summary>
        /// 操作返回数据条数
        /// </summary>
        public int total { get; set; }
    }

    /// <summary>
    /// 表示 ajax 操作结果类型的枚举
    /// </summary>
    public enum ResultType
    {
        /// <summary>
        /// 消息结果类型
        /// </summary>
        info,
        /// <summary>
        /// 成功结果类型
        /// </summary>
        success,
        /// <summary>
        /// 警告结果类型
        /// </summary>
        warning,
        /// <summary>
        /// 异常结果类型
        /// </summary>
        error
    }
}
