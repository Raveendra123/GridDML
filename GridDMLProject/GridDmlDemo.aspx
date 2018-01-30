<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridDmlDemo.aspx.cs" Inherits="GridDMLProject.GridDmlDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:GridView ID="gvDetails" runat="server" ShowFooter="true" AutoGenerateColumns="False" DataKeyNames="UserId,UserName" OnRowEditing="gvDetails_RowEditing" OnRowCancelingEdit="gvDetails_RowCancelingEdit" OnRowUpdating="gvDetails_RowUpdating" OnRowDeleting="gvDetails_RowDeleting" OnRowCommand="gvDetails_RowCommand">
            <Columns>
                <asp:TemplateField HeaderText="Select">
                    <EditItemTemplate>
                        <asp:Button ID="BtnUpdate" runat="server" Text="Update" CommandName="Update" />
                        <asp:Button ID="BtnCancel" runat="server" Text="Cancel" CommandName="Cancel" />
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:Button ID="ButtonAddNew" runat="server" Text="AddNew"  CommandName="AddNew" ValidationGroup="g1" />
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Button ID="BtnEdit" runat="server"  Text="Edit" CommandName="Edit" />
                        <asp:Button ID="BtnDelete" runat="server" Text="Delete" CommandName="Delete" OnClientClick="return confirm('Are you sure to delete the record')" />
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="UserName">
                    <EditItemTemplate>
                        <asp:Label ID="Lblusername" runat="server" Text='<%#Eval("UserName") %>'></asp:Label>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TxtFooterusername" runat="server"></asp:TextBox>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LblUserName" runat="server" Text='<%#Eval("UserName") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="City">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtCity" runat="server" Text='<%#Eval("city") %>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TxtFooterCity" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TxtFooterCity" ErrorMessage="*" ValidationGroup="g1"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LblCity" runat="server" Text='<%#Eval("city") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
                <asp:TemplateField HeaderText="Designation">
                    <EditItemTemplate>
                        <asp:TextBox ID="TxtDesignation" runat="server" Text='<%#Eval("Designation")%>'></asp:TextBox>
                    </EditItemTemplate>
                    <FooterTemplate>
                        <asp:TextBox ID="TxtFooterDesignation" runat="server"></asp:TextBox>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TxtFooterDesignation" ErrorMessage="*" ValidationGroup="g1"></asp:RequiredFieldValidator>
                    </FooterTemplate>
                    <ItemTemplate>
                        <asp:Label ID="LblDesignation" runat="server" Text='<%#Eval("Designation") %>'></asp:Label>
                    </ItemTemplate>
                </asp:TemplateField>
            </Columns>
        </asp:GridView>
    
    </div>
        <asp:Label ID="Label1" runat="server" ForeColor="Green"></asp:Label>
    </form>
</body>
</html>
