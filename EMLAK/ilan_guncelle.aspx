<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ilan_guncelle.aspx.cs" Inherits="yonetim_ilan_ekle" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .style1
        {
            width: 571px;
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
                <td colspan="2" style="text-align: center">
                    <strong>İLAN GÜNCELLEME</strong></td>
            </tr>
            <tr>
                <td class="style2">
                    İlan Adı</td>
                <td>
                    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Fiyat</td>
                <td>
                    <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="style2">
                    Açıklama</td>
                <td>
                    <asp:TextBox ID="TextBox3" runat="server" Height="152px" TextMode="MultiLine" 
                        Width="267px"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td colspan="2" style="text-align: center">
                    <asp:Button ID="Button1" runat="server" onclick="Button1_Click" 
                        Text="İlan Güncelle" />
                    <br />
                    <asp:Label ID="Label1" runat="server"></asp:Label>
                </td>
            </tr>
        </table>
    </div>
    </form>
</body>
</html>
