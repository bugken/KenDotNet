using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcLoginDemo.Models;

namespace MvcLoginDemo.Controllers
{
    public class SysAdminController : Controller
    {
        //
        // GET: /SysAdmin/

        public ActionResult Index()
        {
            return View("AdminLogin");
        }
        /// <summary>
        /// 用户登录的控制器
        /// </summary>
        /// <returns></returns>
        public ActionResult AdminLogin()
        { 
            //1.获取数据
            SysAdmin objAdmin = new SysAdmin()
            {
                LoginId = Convert.ToInt32(Request.Params["loginId"]),
                LoginPwd = Request.Params["loginPwd"]
            };
            //2.业务处理
            objAdmin = new SysAdminService().AdminLogin(objAdmin);
            if (objAdmin != null)
            {
                ViewData["info"] = "欢迎" + objAdmin.AdminName;
            }
            else
            {
                ViewData["info"] = "用户名或密码错误，登录失败";
            }
            //3.返回数据
            return View("AdminLogin");
        }

    }
}
