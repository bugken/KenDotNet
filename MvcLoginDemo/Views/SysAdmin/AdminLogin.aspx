<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>管理员登录</title>
        <style>
        form{
            color:#575454;  
            width:500px;
            margin: auto;
            font-size:15px;
            margin-top:260px;
	    }
        #spanpsd{
            margin-left:125px;
            color:white;
        }
        #spanuser{
            margin-left:110px;
            color:white;
        }
        div{
            margin:30px auto;
            align-content:center;
        } 
        .textbox{
            border:solid 1px;
            background:rgba(0, 0, 0, 0);
        }
        body{
            background-image: url("./BackGround/bg.jpg");
        }
    </style>
</head>
<body>
    <div>
        <form method="post" action="/SysAdmin/AdminLogin">
        <div>
            <div>
                用户ID:<input name="loginid" type="text" />
            </div>
            <div>
                密码:<input name="loginPwd" type="password"/>
            </div>
            <div>
                <input type="submit" value="登录" /><br/><br/>
                <%=ViewData["info"] %>
            </div>
        </div>
        </form>
    </div>
</body>
</html>
