<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ilan.aspx.cs" Inherits="yonetim_ilan" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 800px;
        }
        .style2
        {
            font-weight: bold;
            text-align: center;
        }
        .style3
        {
            text-align: center;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <table align="center" class="style1">
            <tr>
                <td>
                    <a href="ilan_ekle.aspx">İlan Ekle</a></td>
                <td>
                    <a href="ilan.aspx">İlanlar</a></td>
                <td>
                    <a href="kullanici.aspx">Kullanici Bilgileri</a></td>
                <td>
                    <a href="harita.aspx">HARİTA DA ARAMA</a></td>
                                             <td>
                    <asp:LinkButton ID="LinkButton1" runat="server" onclick="LinkButton1_Click">Çıkış Yap</asp:LinkButton>
                </td>
            </tr>
        </table>

        <table align="center" class="style1" border="1">
            <tr>
                <td class="style2">
                    İlan Adı</td>
                <td class="style2">
                    Fiyat</td>
                <td class="style2">
                    İşlem</td>
            </tr>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
            
        </table>
    </div>
    </form>
</body>
</html>
