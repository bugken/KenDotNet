using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcLoginDemo.Models
{
    /// <summary>
    /// 管理员实体类
    /// </summary>
    [Serializable]
    public class SysAdmin
    {
        public int LoginId { get; set; }
        public int LoginPwd { get; set; }
        public int AdminName { get; set; }
    }
}