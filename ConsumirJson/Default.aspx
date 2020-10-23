<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ConsumirJson.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title>Consumindo JSon</title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <asp:Button ID="btnJson" runat="server" Text="Ler Arquivos Json" OnClick="btnJson_Click" />

            <br />
            Código do ALuno<br />
            <asp:TextBox ID="txtCdAluno" runat="server" Width="139px"></asp:TextBox>
            <br />
            <asp:Label ID="lblsituacao" runat="server" ForeColor="#0033CC" Text="."></asp:Label>
            <br />

            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="false">
                <Columns>
                    <asp:BoundField DataField="userId" HeaderText="Id" />
                    <asp:BoundField DataField="id" HeaderText="Title" />
                    <asp:BoundField DataField="title" HeaderText="Url" />
                    <asp:BoundField DataField="body" HeaderText="Imagem" />
                </Columns>
            </asp:GridView>

        </div>
    </form>
</body>
</html>
