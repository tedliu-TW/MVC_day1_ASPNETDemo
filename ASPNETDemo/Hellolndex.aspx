<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Hellolndex.aspx.cs" Inherits="ASPNETDemo.Hellolndex" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Label ID="LabelMessage" runat="server" Text="Hello" ForeColor="RoyalBlue"></asp:Label>
        </div>
        <div>
            <asp:TextBox ID="xname" runat="server"></asp:TextBox>
            <asp:Button ID="HelloButton" runat="server" Text="Say Hello" OnClick="HelloButton_Click" />
        </div>
    </form>
</body>
</html>
