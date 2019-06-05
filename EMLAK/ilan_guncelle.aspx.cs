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

        if (!IsPostBack)
        {
            if (Request.QueryString["id"] != null)
            {
                OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Server.MapPath("data.accdb") + "");
                baglan.Open();
                OleDbCommand sorgu = new OleDbCommand("select * from ilan where id=" + Request.QueryString["id"] + "", baglan);
                OleDbDataReader oku = sorgu.ExecuteReader();
                while (oku.Read())
                {
                    TextBox1.Text = oku["ilan_adi"].ToString();
                    TextBox2.Text = oku["fiyat"].ToString();
                    TextBox3.Text = oku["aciklama"].ToString();
                }

                baglan.Close();
            }
        }

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Server.MapPath("data.accdb") + "");
        baglan.Open();

        OleDbCommand sorgu = new OleDbCommand("update ilan set ilan_adi='" + TextBox1.Text + "', fiyat='" + TextBox2.Text + "', aciklama='" + TextBox3.Text + "' where id=" + Request.QueryString["id"] + "", baglan);
        sorgu.ExecuteNonQuery();

        Label1.Text = "İlan Güncellendi";

        baglan.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["durum"] = "0";
        Response.Redirect("ilan_guncelle.aspx");
    }
}