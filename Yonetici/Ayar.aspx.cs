using System;
using System.Collections.Generic;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;

public partial class Yonetici_Ayar : System.Web.UI.Page
{
    DataTable _dtMenu;
    DataTable _dtYonetici;
    DataTable _dtAyar;
    Data _sysData = new Data();
    OleDbConnection _cnn;
    OleDbCommand _cmd;
    private bool _blSil;
    string Baglan = "Provider=Microsoft.jet.OLEDB.4.0; data source=" + HttpContext.Current.Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Session["idYonetici"] == null)
        {
            Response.Redirect("Giris.aspx");
        }
        if (!Page.IsPostBack)
        {
            _fncYoneticiListesi();
            _fncMenuListesi();
            _fncAyarListesi();

        }
    }
    //private void _fncKayitSistemi(string[] array,string[] field,int FieldCount)
    //{
    //    string sql = "INSERT INTO Yonetici (";
    //    for (int i = 0; i < field.Length; i++)
    //    {
    //        if (i == FieldCount)
    //        {
    //            sql += field[i].ToString();
    //        }
    //        else
    //        {
    //            sql += field[i].ToString() + ",";
    //        }
    //    }
    //    sql += ") VALUES (";
    //    for (int i = 0; i < array.Length; i++)
    //    {
    //        if (i == FieldCount)
    //        {
    //            sql += array[i].ToString();
    //        }
    //        else
    //        {
    //            sql += array[i].ToString() + ",";
    //        }
    //    }
    //    sql += ")";
    //    _cnn = new OleDbConnection(Baglan);
    //    _cnn.Open();
    //    _cmd = _cnn.CreateCommand();
    //    _cmd.CommandText = sql;
    //    _cmd.ExecuteNonQuery();


    //}

    private void _fncYoneticiListesi()
    {
        try
        {
            _dtYonetici = _sysData._fncSelect("SELECT idYonetici,Yonetici FROM Yonetici");
            ListBox1.DataSource = _dtYonetici;
            ListBox1.DataValueField = "idYonetici";
            ListBox1.DataTextField = "Yonetici";
            ListBox1.DataBind();
        }
        catch (Exception)
        {

            Response.Write("_fncYoneticiListesi()");
        }
    }
    private void _fncAyarListesi()
    {
        try
        {
            _dtAyar = _sysData._fncSelect("SELECT PageTitle,PageFooter,Keywords,Description,Email,Telefon,AdSoyad FROM Ayar");
            TextBox20.Text = _dtAyar.Rows[0]["PageTitle"].ToString();
            TextBox21.Text = _dtAyar.Rows[0]["PageFooter"].ToString();
            TextBox25.Text = _dtAyar.Rows[0]["Keywords"].ToString();
            TextBox26.Text = _dtAyar.Rows[0]["Description"].ToString();
            TextBox22.Text = _dtAyar.Rows[0]["Email"].ToString();
            TextBox23.Text = _dtAyar.Rows[0]["Telefon"].ToString();
            TextBox24.Text = _dtAyar.Rows[0]["AdSoyad"].ToString();
        }
        catch (Exception)
        {

            Response.Write("_fncAyarListesi()");
        }
    }
    private void _fncMenuListesi()
    {
        try
        {
            _dtMenu = _sysData._fncSelect("SELECT idMenu,MenuAdi FROM Menu");
            ListBox2.DataSource = _dtMenu;
            ListBox2.DataValueField = "idMenu";
            ListBox2.DataTextField = "MenuAdi";
            ListBox2.DataBind();
        }
        catch (Exception)
        {
            Response.Write("_fncMenuListesi()");
        }
    }
    protected void Button3_Click(object sender, EventArgs e)
    {
        try
        {
            _blSil = _sysData._fncExecuteNonQuery("DELETE FROM Yonetici WHERE idYonetici=" + ListBox1.SelectedValue + "");
            _lblMesaj3.Text = "Silindi.";
            _fncYoneticiListesi();
        }
        catch (Exception)
        {
            Response.Write("Button3_Click = Yonetici Sil");
        }
    }

    //protected void _btnYoneticiKaydet_Click(object sender, EventArgs e)
    //{
    //    string[] FieldArray = new string[2];
    //    FieldArray[0] = "Yonetici";
    //    FieldArray[1] = "Sifre";
    //    string[] YoneticiArray = new string[2];
    //    YoneticiArray[0] = TextBox1.Text;
    //    YoneticiArray[1] = TextBox2.Text;
    //    this._fncKayitSistemi(YoneticiArray,FieldArray,1);
    //}
    protected void _btnYoneticiKaydet_Click(object sender, EventArgs e)
    {
        try
       {
               _cnn = new OleDbConnection(Baglan);
               _cnn.Open();
               _cmd = _cnn.CreateCommand();
               _cmd.CommandText = "INSERT INTO Yonetici (Yonetici,Sifre) VALUES (@Yonetici,@Sifre)";
               _cmd.Parameters.AddWithValue("Yonetici", TextBox1.Text);
               _cmd.Parameters.AddWithValue("Sifre", TextBox2.Text);
               _cmd.ExecuteNonQuery();
               _cnn.Close();
               TextBox1.Text = "";
               TextBox2.Text = "";
               _lblMesaj.Text = "Kayıt Edildi.";
               _fncYoneticiListesi();
         }
        catch (Exception)
        {
            Response.Write("_btnYoneticiKaydet_Click");
        }
    }
    protected void Button15_Click(object sender, EventArgs e)
    {
        try
        {
            _dtYonetici = null;
            _dtYonetici = _sysData._fncSelect("SELECT Yonetici,Sifre FROM Yonetici WHERE idYonetici=" + ListBox1.SelectedValue + "");
            TextBox1.Text = _dtYonetici.Rows[0]["Yonetici"].ToString();
            TextBox2.Text = _dtYonetici.Rows[0]["Sifre"].ToString();

        }
        catch (Exception)
        {
            
            Response.Write("Button15_Click= Yonetici Duzenle");
        }
    }
    protected void _btnAyarKaydet_Click(object sender, EventArgs e)
    {
        try
        {
            _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            _cmd = _cnn.CreateCommand();
            _cmd.CommandText = "UPDATE Ayar SET PageTitle=@PageTitle,PageFooter=@PageFooter,Keywords=@Keywords,Description=@Description,Email=@Email,Telefon=@Telefon,AdSoyad=@AdSoyad WHERE idAyar=@idAyar";
            _cmd.Parameters.AddWithValue("PageTitle", TextBox20.Text);
            _cmd.Parameters.AddWithValue("PageFooter", TextBox21.Text);
            _cmd.Parameters.AddWithValue("Keywords", TextBox25.Text);
            _cmd.Parameters.AddWithValue("Description", TextBox26.Text);
            _cmd.Parameters.AddWithValue("Email", TextBox22.Text);
            _cmd.Parameters.AddWithValue("Telefon", TextBox23.Text);
            _cmd.Parameters.AddWithValue("AdSoyad", TextBox24.Text);
            _cmd.Parameters.AddWithValue("idAyar", 1);
            _cmd.ExecuteNonQuery();
            _cnn.Close();
            _fncAyarListesi();
            _lblMesaj1.Text = "Güncellendi.";
        }
        catch (Exception)
        {
            Response.Write("_btnAyarKaydet_Click");
        }
    }
    protected void Button19_Click(object sender, EventArgs e)
    {
        try
        {
            _blSil = _sysData._fncExecuteNonQuery("DELETE FROM Menu WHERE idMenu=" + ListBox2.SelectedValue + "");
            _lblMesaj4.Text = "Silindi.";
            _fncMenuListesi();
        }
        catch (Exception)
        {
            Response.Write("Hata.aspx");
        }
    }
    protected void Button18_Click(object sender, EventArgs e)
    {
        try
        {
            _dtMenu = null;
            _dtYonetici = _sysData._fncSelect("SELECT MenuAdi,MenuUrl FROM Menu WHERE idMenu=" + ListBox2.SelectedValue + "");
            TextBox11.Text = _dtYonetici.Rows[0]["MenuAdi"].ToString();
            TextBox12.Text = _dtYonetici.Rows[0]["MenuUrl"].ToString();

        }
        catch (Exception)
        {
            
             Response.Write("Hata.aspx");
        }
    }
    protected void _btnMenuKaydet_Click(object sender, EventArgs e)
    {
        try
        {
                _cnn = new OleDbConnection(Baglan);
                _cnn.Open();
                _cmd = _cnn.CreateCommand();
                _cmd.CommandText = "INSERT INTO Menu (MenuAdi,MenuUrl) VALUES (@MenuAdi,@MenuUrl)";
                _cmd.Parameters.AddWithValue("MenuAdi", TextBox11.Text);
                _cmd.Parameters.AddWithValue("MenuUrl", TextBox12.Text);
                _cmd.ExecuteNonQuery();
                _cnn.Close();
                _fncMenuListesi();
                TextBox11.Text = "";
                TextBox12.Text = "";
                _lblMesaj0.Text = "Kayıt Edildi.";
            
        }
        catch (Exception)
        {
            Response.Write("Hata.aspx");
       }
    }

    protected void _btnYoneticiKaydet0_Click(object sender, EventArgs e)
    {
        try
        {
                _cnn = new OleDbConnection(Baglan);
               _cnn.Open();
               _cmd = _cnn.CreateCommand();
               _cmd.CommandText = "UPDATE Yonetici SET Yonetici=@Yonetici,Sifre=@Sifre WHERE idYonetici=@idYonetici";
               _cmd.Parameters.AddWithValue("Yonetici",TextBox1.Text);
               _cmd.Parameters.AddWithValue("Sifre", TextBox2.Text);
               _cmd.Parameters.AddWithValue("idYonetici", ListBox1.SelectedValue);
               _cmd.ExecuteNonQuery();
               _fncYoneticiListesi();
               _lblMesaj3.Text = "Güncellendi.";
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
    protected void Button20_Click(object sender, EventArgs e)
    {
        try
        {
         _cnn = new OleDbConnection(Baglan);
        _cnn.Open();
        _cmd = _cnn.CreateCommand();
        _cmd.CommandText = "UPDATE Menu SET MenuAdi=@MenuAdi,MenuUrl=@MenuUrl WHERE idMenu=@idMenu";
        _cmd.Parameters.AddWithValue("MenuAdi", TextBox11.Text);
        _cmd.Parameters.AddWithValue("MenuUrl", TextBox12.Text);
        _cmd.Parameters.AddWithValue("idMenu", ListBox2.SelectedValue);
        _cmd.ExecuteNonQuery();
        _cnn.Close();
        TextBox11.Text = "";
        TextBox12.Text = "";
        _fncMenuListesi();
        }
        catch (Exception)
        {
            Response.Redirect("Hata.aspx");
        }
    }
}