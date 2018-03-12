using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;
using System.Data;

public partial class Yonetici_Login : System.Web.UI.Page
{
    public bool Giris;
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    Data _clsData = new Data();
    string Login;
    string user;
    string pass;
    public static bool Login_Ok;
    protected void Page_Load(object sender, EventArgs e)
    {
        Panel1.Enabled = false;
        user = Request.QueryString["username"];
        pass = Request.QueryString["password"];
        Login = _clsData._fncSelectString("SELECT Sifre FROM Yonetici");
        if (Login == pass)
        {
            Ayar.AdminLogin = true;
            Response.Redirect("Default.aspx");
        }
        else
        {
            Panel1.Enabled = true;
        }
    }
    protected void Button1_Click(object sender, EventArgs e)
    {


    }
    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {
        Panel1.Enabled = false;
    }
}