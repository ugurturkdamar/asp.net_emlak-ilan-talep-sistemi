using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yonetim_ilan_ekle : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["durum"] != "1") Response.Redirect("default.aspx");
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Server.MapPath("data.accdb") + "");
        baglan.Open();

        OleDbCommand sorgu = new OleDbCommand("insert into ilan(ilan_adi, fiyat, resim, aciklama) values('" + TextBox1.Text + "','" + TextBox2.Text + "','" + FileUpload1.FileName + "','" + TextBox3.Text + "')", baglan);
        sorgu.ExecuteNonQuery();

        FileUpload1.SaveAs(Server.MapPath("resim/" + FileUpload1.FileName));
        Label1.Text = "İlan Eklendi";

        baglan.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["durum"] = "0";
        Response.Redirect("ilan_ekle.aspx");
    }
}