<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DetailListView.aspx.cs" Inherits="GridDMLProject.DetailListView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:DetailsView ID="DetailsView1" runat="server" AllowPaging="True" AutoGenerateRows="False" DataSourceID="SqlDataSource1" Height="50px" Width="125px">
            <Fields>
                <asp:BoundField DataField="UserId" HeaderText="UserId" InsertVisible="False" ReadOnly="True" SortExpression="UserId" />
                <asp:BoundField DataField="UserName" HeaderText="UserName" SortExpression="UserName" />
                <asp:BoundField DataField="city" HeaderText="city" SortExpression="city" />
                <asp:BoundField DataField="Designation" HeaderText="Designation" SortExpression="Designation" />
                <asp:TemplateField HeaderText="UserName">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("UserName") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City">
                    <ItemTemplate>
                        <asp:Label ID="Label1" runat="server" Text='<%#Eval("city") %>' ></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Fields>
            <PagerSettings Mode="NextPrevious" />
        </asp:DetailsView>
    
    </div>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:DetailsConnectionString %>" SelectCommand="SELECT [UserId], [UserName], [city], [Designation] FROM [Employee_Details]"></asp:SqlDataSource>
    </form>
</body>
</html>
