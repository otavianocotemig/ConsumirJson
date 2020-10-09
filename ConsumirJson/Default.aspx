<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConsumirJson.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="userId" HeaderText="userId" />
                    <asp:BoundField DataField="id" HeaderText="id" />
                    <asp:BoundField DataField="title" HeaderText="title" />
                    <asp:BoundField DataField="body" HeaderText="body" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
