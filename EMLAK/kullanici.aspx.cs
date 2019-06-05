using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yonetim_kullanici : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["durum"] != "1") Response.Redirect("default.aspx");

        if (!IsPostBack)
        {

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Server.MapPath("data.accdb") + "");
            baglan.Open();
            OleDbCommand sorgu = new OleDbCommand("select * from yonet", baglan);
            OleDbDataReader oku = sorgu.ExecuteReader();
            while (oku.Read())
            {
                TextBox1.Text = oku["kullanici"].ToString();
                TextBox2.Text = oku["parola"].ToString();
            }

            baglan.Close();
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Server.MapPath("data.accdb") + "");
        baglan.Open();

        OleDbCommand sorgu = new OleDbCommand("update yonet set kullanici='" + TextBox1.Text + "', parola='" + TextBox2.Text + "'", baglan);
        sorgu.ExecuteNonQuery();

        Label1.Text = "Güncellendi";

        baglan.Close();
    }
    protected void LinkButton1_Click(object sender, EventArgs e)
    {
        Session["durum"] = "0";
        Response.Redirect("kullanici.aspx");
    }
}