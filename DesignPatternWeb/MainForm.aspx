<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainForm.aspx.cs" Inherits="DesignPatternWeb.MainForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div id="SelectPattern">
            <asp:DropDownList ID="ddlDemoList" runat="server" AutoPostBack="True"></asp:DropDownList>  
            <asp:Button ID="btnRun" runat="server" Text="Run" OnClick="btnRun_Click" />
        </div>
        <asp:Panel ID="pnlDecorator" runat="server" Visible="False">
            <div>
                <span>飲料類型</span>
                <asp:RadioButtonList runat="server" ID="beverageType" AutoPostBack="True" RepeatColumns="3" OnSelectedIndexChanged="beverageType_SelectedIndexChanged">
                    <asp:ListItem Text="Coffee" Value="C"></asp:ListItem>
                    <asp:ListItem Text="Soymilk" Value="S"></asp:ListItem>
                    <asp:ListItem Text="Tea" Value="T"></asp:ListItem>
                </asp:RadioButtonList>
            </div>
            <div>
                <span>配料</span>
                <asp:CheckBoxList runat="server" ID="toppingList" RepeatColumns="3" >
                    <asp:ListItem Text="Caramel" Value="C"></asp:ListItem>
                    <asp:ListItem Text="Cream" Value="D"></asp:ListItem>
                    <asp:ListItem Text="Whip" Value="W"></asp:ListItem>
                </asp:CheckBoxList>
            </div>
        </asp:Panel>
        <div>
            <asp:Label ID="lblResult" runat="server" Text=" "></asp:Label>    
        </div>
    </form>
</body>
</html>
