<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="default.aspx.cs" Inherits="BloodDonorService.WebClient._default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:TextBox ID="txtBloodGroup" runat="server"></asp:TextBox>
        <asp:TextBox ID="txtPinCode" runat="server"></asp:TextBox><br />
        <asp:Button ID="btnCallService" runat="server" Text="Get Donor Name" OnClick="btnCallService_Click" />
        <asp:Label ID="lblResult" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
