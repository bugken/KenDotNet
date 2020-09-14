<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>管理员登录</title>
</head>
<body>
    <div>
        <form method="post" action="#">
            用户名：<input name="loginid" type="text" />
            密码：<input name="loginPwd" type="password"/>
            <input type="submit" value="登录" />
        </form>
    </div>
</body>
</html>
