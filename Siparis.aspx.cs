using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Siparis : System.Web.UI.Page
{
    string _SiparisID;
    string _SiparisHostingResim;
    public string _StrPageTitle;
    public string _StrPageFooter;
    public string _StrPageKeywords;
    public string _StrPageDescription;
    Data _sysData = new Data();
    Ayar _sysAyar = new Ayar();
    public DataTable _dtSiparis;
    public DataTable _dtMenu;
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        _SiparisID = Request.QueryString["Paket"];
        try
        {
            _dtMenu = _sysData._fncSelect("SELECT idHostingTur,TurAdi,Resim FROM HostingTur");
            _SiparisHostingResim = _sysData._fncSelectString("SELECT [HostingTur.Resim] FROM Paket INNER JOIN HostingTur ON Paket.idHostingTur=HostingTur.idHostingTur WHERE idPaket=" + Convert.ToInt32(_SiparisID));
            //ImageMap1.ImageUrl = _SiparisHostingResim;
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
        try
        {
            if (_SiparisID == null)
            {
                Response.Redirect("Hata.aspx");
            }
            else
            {
                _dtSiparis = _sysData._fncSelect("SELECT [Paket.PaketAdi],[Paket.Alan],[Paket.Trafik],[Paket.Db],[Paket.SubDomain],[Paket.Email],[HostingTur.TurAdi],[Paket.AylikFiyat],[Paket.YillikFiyat] FROM Paket INNER JOIN HostingTur ON Paket.idHostingTur=HostingTur.idHostingTur WHERE idPaket=" + Convert.ToInt32(_SiparisID));
                _lblHostingAdi.Text = _dtSiparis.Rows[0]["HostingTur.TurAdi"].ToString();
                _lblPaketAdi.Text = _dtSiparis.Rows[0]["Paket.PaketAdi"].ToString();
                Label10.Text = _dtSiparis.Rows[0]["Paket.PaketAdi"].ToString();
                Label11.Text = _dtSiparis.Rows[0]["Paket.Alan"].ToString();
                Label12.Text = _dtSiparis.Rows[0]["Paket.Trafik"].ToString();
                Label13.Text = _dtSiparis.Rows[0]["Paket.Db"].ToString();
                Label14.Text = _dtSiparis.Rows[0]["Paket.SubDomain"].ToString();
                Label15.Text = _dtSiparis.Rows[0]["Paket.Email"].ToString();
                Label16.Text = _dtSiparis.Rows[0]["Paket.AylikFiyat"].ToString();
                Label18.Text = _dtSiparis.Rows[0]["Paket.YillikFiyat"].ToString();
            }

        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        Response.Redirect("Default.aspx");
    }
    protected void Button2_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "INSERT INTO Siparis ([idPaket],[Domain],[Ad],[Soyad],[Telefon],[Email],[Tarih],[Onay]) VALUES (@idPaket,@Domain,@Ad,@Soyad,@Telefon,@Email,@Tarih,@Onay)";
            _cmd.Parameters.AddWithValue("idPaket", Convert.ToInt32(_SiparisID));
            _cmd.Parameters.AddWithValue("Domain", TextBox5.Text);
            _cmd.Parameters.AddWithValue("Ad", TextBox1.Text);
            _cmd.Parameters.AddWithValue("Soyad", TextBox2.Text);
            _cmd.Parameters.AddWithValue("Telefon",TextBox3.Text);
            _cmd.Parameters.AddWithValue("Email", TextBox4.Text);
            _cmd.Parameters.AddWithValue("Tarih", DateTime.Now.ToString());
            _cmd.Parameters.AddWithValue("Onay",true);
            _cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }

        Response.Redirect("Odeme.aspx?SiparisVerildi=Onay");
    }
}