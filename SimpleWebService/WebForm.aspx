<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm.aspx.cs" Inherits="SimpleWebService.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>New page</title>
</head>
<body>
    <form id="form1" runat="server">
    <asp:TextBox ID="LengthInput" runat="server"></asp:TextBox>
    <asp:Button id="SubmitButton" Text="Submit" runat="server" />
    <asp:Label ID="AnimalsOutput" runat="server"></asp:Label>
    </form>
</body>
</html>
