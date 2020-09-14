﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace MvcLoginDemo.Models
{
    /// <summary>
    /// 管理员实体类
    /// </summary>
    [Serializable]
    public class SysAdmin
    {
        public int LoginId { get; set; }
        public string LoginPwd { get; set; }
        public string AdminName { get; set; }
    }
}