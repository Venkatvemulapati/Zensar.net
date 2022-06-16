<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<title></title>
</head>
<body style="height: 321px">
<form id="form1" runat="server">
<div>
SELECT MOBILE<asp:DropDownList ID="DropDownList1" runat="server" Height="35px" Width="150px" style="margin-left: 28px" AutoPostBack="True" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
</asp:DropDownList>
<br />



</div>
<asp:Image ID="Image1" runat="server" Height="151px" style="margin-left: 63px; margin-top: 36px" Width="135px" />
<br />
<br />
<br />
<asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
<br />
<asp:Button ID="button1" runat="server" Text="CLICK FOR PRICE" OnClick="button1_Click" />
</form>
</body>
</html>