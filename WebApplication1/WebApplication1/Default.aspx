<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        #Text1 {
            height: 28px;
            width: 149px;
        }
        #Text2 {
            height: 28px;
            width: 149px;
        }
        #lastNameTextBox {
            width: 123px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            What is your first name?&nbsp; <input id="firstNameTextBox" type="text" /><br />
            What is your last name?&nbsp;
            <input id="lastNameTextBox" type="text" /></div>
    </form>
    <p>
        <input id="Click Me" accept="Ok" type="button" value="Click Me" /></p>
</body>
</html>
