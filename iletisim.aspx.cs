using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.OleDb;

public partial class iletisim : System.Web.UI.Page
{
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    string Baglan ="Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        TextBox1.Text = "";
        TextBox2.Text = "";
        TextBox3.Text = "";
        TextBox4.Text = "";
        TextBox5.Text = "";
        Label6.Text = "";
    }

    protected void Button1_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = new OleDbCommand("INSERT INTO iletisim (Ad,Soyad,Email,Konu,Aciklama,Tarih,Ok) VALUES(@Ad,@Soyad,@Email,@Konu,@Aciklama,@Tarih,@Ok)", _cnn);
            _cmd.Parameters.Add("@Ad", OleDbType.Variant).Value = TextBox1.Text;
            _cmd.Parameters.Add("@Soyad", OleDbType.Variant).Value = TextBox2.Text;
            _cmd.Parameters.Add("@Email", OleDbType.Variant).Value = TextBox3.Text;
            _cmd.Parameters.Add("@Konu", OleDbType.Variant).Value = TextBox4.Text;
            _cmd.Parameters.Add("@Aciklama", OleDbType.Variant).Value = TextBox5.Text;
            _cmd.Parameters.Add("@Tarih", OleDbType.Variant).Value = DateTime.Now;
            _cmd.Parameters.Add("@Ok", OleDbType.Variant).Value = 1;
            _cmd.ExecuteNonQuery();
            Label6.Text = "Mesajınız Gönderilmiştir. Teşekkür Ederiz..";
        }
        catch (Exception)
        {
            Label6.Text = "Hata Oluştu. Sistem Hatayı Yöneticiye Bildirdi Lütfen Hatanın Giderilmesini Bekleyiniz..";
        }
    }
}