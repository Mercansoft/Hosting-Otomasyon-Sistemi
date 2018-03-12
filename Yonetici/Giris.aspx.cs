using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class Yonetici_Giris : System.Web.UI.Page
{
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\Sirketv1Db.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void login_Click(object sender, EventArgs e)
    {
        _cnn = new OleDbConnection(Baglan);
        _cmd = new OleDbCommand("SELECT * FROM Yonetici WHERE Yonetici=@Yonetici AND Sifre=@Sifre", _cnn);
        _cnn.Open();
        _cmd.Parameters.AddWithValue("Yonetici", username.Text);
        _cmd.Parameters.AddWithValue("Sifre", password.Text);
        OleDbDataReader _dr = _cmd.ExecuteReader();
        if (_dr.Read())
        {
            Session["idYonetici"] = Convert.ToInt32(_dr["idYonetici"]);
            Response.Redirect("Default.aspx");
        }
        else
        {
            Label1.Text = "Kullanıcı Adı veya Şifre Yanlış";
        }
    }
}