<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="GridIDML.aspx.cs" Inherits="GridDMLProject.GridIDML" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">

.Gridview
{
font-family:Verdana;

font-size:10pt;

font-weight:normal;

color:black;
}
</style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
   
        <asp:GridView ID="gvDetails" runat="server" AutoGenerateColumns="False"  DataKeyNames="UserId,UserName" onrowediting="gvDetails_RowEditing" onrowupdating="gvDetails_RowUpdating" OnRowCancelingEdit="gvDetails_RowCancelingEdit" OnRowDeleting="gvDetails_RowDeleting" OnRowCommand="gvDetails_RowCommand" CssClass="Gridview" HeaderStyle-BackColor="#61A6F8" 

ShowFooter="true" HeaderStyle-Font-Bold="true" HeaderStyle-ForeColor="White" >
            <Columns>
                
                <asp:TemplateField HeaderText="Edit/Delete">

                    <EditItemTemplate>
<asp:Button ID ="imgbtnUpdate" runat="server" CommandName="Update" ToolTip="Update" Text="Update"  />
<asp:Button ID ="imgbtnCancel" runat="server" CommandName="Cancel" ToolTip="Cancel" Text="Cancel" />
</EditItemTemplate>
  <ItemTemplate>              
      <asp:Button ID="imgbtnEdit" CommandName="Edit" runat="server" Text="Edit" ToolTip="Edit"   />
      <asp:Button ID="imgbtnDelete" CommandName="Delete" Text="Delete" runat="server"  ToolTip="Delete" OnClientClick="return confirm('Are you sure')" />
   </ItemTemplate>
 <FooterTemplate>
 <asp:Button ID="imgbtnAdd" runat="server" CommandName="AddNew"  Text="Add New user" ToolTip="Add new User" ValidationGroup="validaiton" />
 </FooterTemplate>
</asp:TemplateField>
<asp:TemplateField HeaderText="UserName">
<EditItemTemplate>
<asp:Label ID="lbleditusr" runat="server" Text='<%#Eval("Username") %>'/>
</EditItemTemplate>
<ItemTemplate>
<asp:Label ID="lblitemUsr" runat="server" Text='<%#Eval("UserName") %>'/>
</ItemTemplate>
<FooterTemplate>
<asp:TextBox ID="txtftrusrname" runat="server"/>
<asp:RequiredFieldValidator ID="rfvusername" runat="server" ControlToValidate="txtftrusrname" Text="*" ValidationGroup="validaiton"/>
</FooterTemplate> 
</asp:TemplateField>
 <asp:TemplateField HeaderText="City">

<EditItemTemplate>

<asp:TextBox ID="txtcity" runat="server" Text='<%#Eval("City") %>'/>

</EditItemTemplate>

<ItemTemplate>

<asp:Label ID="lblcity" runat="server" Text='<%#Eval("City") %>'/>

</ItemTemplate>

<FooterTemplate>

<asp:TextBox ID="txtftrcity" runat="server"/>

<asp:RequiredFieldValidator ID="rfvcity" runat="server" ControlToValidate="txtftrcity" Text="*" ValidationGroup="validaiton"/>

</FooterTemplate>

</asp:TemplateField>          
<asp:TemplateField HeaderText="Designation">

<EditItemTemplate>

<asp:TextBox ID="txtDesg" runat="server" Text='<%#Eval("Designation") %>'/>

</EditItemTemplate>

<ItemTemplate>

<asp:Label ID="lblDesg" runat="server" Text='<%#Eval("Designation") %>'/>

</ItemTemplate>

<FooterTemplate>

<asp:TextBox ID="txtftrDesignation" runat="server"/>

<asp:RequiredFieldValidator ID="rfvdesignation" runat="server" ControlToValidate="txtftrDesignation" Text="*" ValidationGroup="validaiton"/>

</FooterTemplate>

</asp:TemplateField>
            </Columns>

            <FooterStyle Wrap="False" />

<HeaderStyle BackColor="#61A6F8" Font-Bold="True" ForeColor="White"></HeaderStyle>
        </asp:GridView>
        <div>

<asp:Label ID="lblresult" runat="server"></asp:Label>

</div>
         </div>
    </form>
</body>
</html>
