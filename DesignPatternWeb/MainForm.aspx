<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="DesignPatternWeb.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <asp:DropDownList ID="ddlDemoList" runat="server"></asp:DropDownList>  
        <asp:Button ID="btnRun" runat="server" Text="Run" OnClick="btnRun_Click" />
        <asp:Label ID="lblResult" runat="server" Text=" "></asp:Label>
    <div>
    
    </div>
    </form>
</body>
</html>
