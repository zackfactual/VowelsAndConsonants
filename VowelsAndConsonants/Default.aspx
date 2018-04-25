<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="VowelsAndConsonants.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Vowels & Consonants</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <p>How many vowels and consonants* are in your string?</p>
            <asp:TextBox ID="inputTextBox" runat="server"></asp:TextBox><br /><br />
            <asp:Button ID="goButton" runat="server" Text="Go" OnClick="goButton_Click" /><br /><br />
            <asp:Label ID="resultLabel" runat="server" Text=""></asp:Label>
            <p style="font-style:italic;">*We will consider the letter Y a consonant for this drill.</p>
        </div>
    </form>
</body>
</html>
