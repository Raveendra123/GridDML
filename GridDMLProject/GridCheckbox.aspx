<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridCheckbox.aspx.cs" Inherits="GridDMLProject.GridCheckbox" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
    </div>
        <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False" DataKeyNames="Userid,username">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <ItemTemplate>
                        <asp:CheckBox ID="C1" runat="server" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:BoundField DataField="UserName" HeaderText="User Name" SortExpression="UserName" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
            </Columns>
        </asp:GridView>
        <asp:Button ID="Button1" runat="server" Text="Submit" OnClick="Button1_Click" />
    &nbsp;<asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
    </form>
</body>
</html>
