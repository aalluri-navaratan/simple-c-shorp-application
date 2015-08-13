<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Student.aspx.cs" Inherits="Student" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div style="height: 488px">
    
        <asp:Label ID="Label1" runat="server" 
            style="z-index: 1; left: 293px; top: 143px; position: absolute; width: 17px" 
            Text="Id"></asp:Label>
        <asp:Label ID="Label2" runat="server" 
            style="z-index: 1; left: 291px; top: 177px; position: absolute; width: 39px" 
            Text="name"></asp:Label>
        <asp:Label ID="Label3" runat="server" 
            style="z-index: 1; left: 294px; top: 214px; position: absolute" Text="Mail"></asp:Label>
        <asp:TextBox ID="txtId" runat="server" 
            style="z-index: 1; left: 390px; top: 142px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtname" runat="server" 
            style="z-index: 1; left: 392px; top: 177px; position: absolute"></asp:TextBox>
        <asp:TextBox ID="txtmail" runat="server" 
            style="z-index: 1; left: 392px; top: 215px; position: absolute"></asp:TextBox>
        <asp:Button ID="AddButton" runat="server" onclick="AddStudent" 
            style="z-index: 1; left: 301px; top: 258px; position: absolute" Text="Insert" />
        <asp:Button ID="UpdateButton" runat="server" onclick="UpdateStudent" 
            style="z-index: 1; left: 387px; top: 259px; position: absolute; right: 668px" 
            Text="Update" />
        <asp:Button ID="DeleteButton" runat="server" onclick="DeleteStudent" 
            style="z-index: 1; left: 481px; top: 259px; position: absolute" Text="Delete" />
        <asp:GridView ID="GridView1" runat="server" 
            style="z-index: 1; left: 754px; top: 143px; position: absolute; height: 133px; width: 187px">
        </asp:GridView>
        <asp:Label ID="ButtonInfo" runat="server" 
            style="z-index: 1; left: 281px; top: 341px; position: absolute" Text="Label" 
            Visible="False"></asp:Label>
    
    </div>
    </form>
</body>
</html>
