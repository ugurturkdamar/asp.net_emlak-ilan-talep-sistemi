using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yonetim_ilan : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["durum"] != "1") Response.Redirect("default.aspx");

        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Server.MapPath("data.accdb") + "");
        baglan.Open();

        if (Request.QueryString["id"] != null)
        {
            OleDbCommand sorgu2 = new OleDbCommand("delete * from ilan where id=" + Request.QueryString["id"] + "", baglan);
            sorgu2.ExecuteNonQuery();
        }

        OleDbCommand sorgu = new OleDbCommand("select * from ilan", baglan);
        OleDbDataReader oku = sorgu.ExecuteReader();
        Label1.Text = "";
        while (oku.Read())
        {
            Label1.Text += "<tr><td>" + oku["ilan_adi"] + "</td><td>" + oku["fiyat"] + "</td><td><a href=ilan.aspx?id=" + oku["id"] + ">sil</a> <a href=ilan_guncelle.aspx?id=" + oku["id"] + ">güncelle</a></td></tr>";
        }
        baglan.Close();
    }
    protected void Button1_Click(object sender, EventArgs e)
    {

    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["durum"] = "0";
        Response.Redirect("ilan.aspx");
    }
}