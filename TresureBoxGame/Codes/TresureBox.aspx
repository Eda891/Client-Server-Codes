<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TresureBox.aspx.cs" Inherits="TresureBoxGame.TresureBox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Tresure Box</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Tresure Box Game</h1>
            <p>There are 10 hidden boxes. Choose as many as you want and see the results.</p>
            <h3>Good luck !!!</h3>
            <asp:TextBox ID="TextBox1" runat="server" Width="212px"></asp:TextBox>

            <asp:Button ID="Button1" runat="server" Text="Enter the numbers" OnClick="Button1_Click" />
            <br />
            <br />
        </div>
        <p>
            <asp:Image ID="Image1" runat="server" Height="346px" style="margin-right: 58px" Width="556px" />
        </p>
    </form>
</body>
</html>
