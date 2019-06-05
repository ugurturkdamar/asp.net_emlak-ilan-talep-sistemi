using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class sisana_Proje_emlak_yonetim_uye_kayit : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {



    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0; Data Source=" + Server.MapPath("data.accdb") + "");
        baglan.Open();
        OleDbCommand sorgu = new OleDbCommand("INSERT INTO yonet (kullanici, parola, email, TCKN, adres, adi_soyadi) VALUES (@kuladi, @sfr, @eml, @tck, @adrs, @adsoyad) ", baglan);

        sorgu.Parameters.AddWithValue("@adsoyad", TextBox1.Text);
        sorgu.Parameters.AddWithValue("@kuladi", TextBox2.Text);
        sorgu.Parameters.AddWithValue("@eml", TextBox3.Text);
        sorgu.Parameters.AddWithValue("@adrs", TextBox4.Text);
        sorgu.Parameters.AddWithValue("@tck", TextBox5.Text);
        sorgu.Parameters.AddWithValue("@sfr", TextBox6.Text);
        sorgu.ExecuteScalar();
        baglan.Close();
    }

    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        TextBox6.Text = "";
    }
}