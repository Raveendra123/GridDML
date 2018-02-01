﻿<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ChartSite.aspx.cs" Inherits="GridDMLProject.ChartSite" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Chart ID="Chart1" runat="server" DataSourceID="SqlDataSource1">
            <series>
                <asp:Series Name="Series1" XValueMember="Year" YValueMembers="Profit">
                </asp:Series>
            </series>
            <chartareas>
                <asp:ChartArea Name="ChartArea1">
                </asp:ChartArea>
            </chartareas>
        </asp:Chart>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="Data Source=MININT-8DSL3GL;Initial Catalog=Details;Integrated Security=True" ProviderName="System.Data.SqlClient" SelectCommand="SELECT Year, Profit FROM results"></asp:SqlDataSource>
    
    </div>
    </form>
</body>
</html>
