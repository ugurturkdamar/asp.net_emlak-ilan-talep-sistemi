<%@ Page Language="C#" AutoEventWireup="true" CodeFile="kullanici.aspx.cs" Inherits="yonetim_kullanici" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 800px;
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
        <table align="center" class="style1">
            <tr>
                <td>
                    Kullanıcı Adı</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    Parola</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" Text="Güncelle" 
                        onclick="Button1_Click" />
                    <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    
    </div>
    </form>
</body>
</html>
