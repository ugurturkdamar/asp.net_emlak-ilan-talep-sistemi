using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class yonetim_Default : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }
    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan;

        baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.15.0; Data Source=" + Server.MapPath(@"\\data.accdb") + "");

        baglan.Open();

        OleDbCommand sorgu = new OleDbCommand("select * from yonet where kullanici='" + TextBox1.Text + "' and parola='" + TextBox2.Text + "' ", baglan);
        OleDbDataReader oku = sorgu.ExecuteReader();

        int varmi = 0;

        while (oku.Read())
        {
            varmi = 1;
        }

        baglan.Close();

        if (varmi == 0) Label1.Text = "Hatalı Giriş";

        else
        {
            Session["durum"] = "1";
            Response.Redirect("ilan.aspx");
        }

    }
}