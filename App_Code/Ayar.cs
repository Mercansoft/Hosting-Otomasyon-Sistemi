using System;
using System.Collections.Generic;
using System.Web;
using System.Data;

/// <summary>
/// Summary description for Ayar
/// </summary>
public class Ayar
{
    public static string _idHosting = "1";
    public static string _idBayi = "3";
    public static bool AdminLogin;
    Data _sysData = new Data();
    public Ayar()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public string _fncGenelAyar(string _strAyarField)
    {
        DataTable _dtAyar = new DataTable();
        string _strDeger = string.Empty;
        _dtAyar= _sysData._fncSelect("SELECT PageTitle,PageFooter,Keywords,Description,Email,Telefon,AdSoyad FROM Ayar");
        switch (_strAyarField)
        {
             case "PageTitle":
                _strDeger = _dtAyar.Rows[0]["PageTitle"].ToString();
                   break;
            case "PageFooter":
                   _strDeger = _dtAyar.Rows[0]["PageFooter"].ToString();
                break;
            case "Keywords":
                _strDeger = _dtAyar.Rows[0]["Keywords"].ToString();
                break;
            case "Description":
                _strDeger = _dtAyar.Rows[0]["Description"].ToString();
                break;
            case "Email":
                _strDeger = _dtAyar.Rows[0]["Email"].ToString();
                break;
            case "Telefon":
                _strDeger = _dtAyar.Rows[0]["Telefon"].ToString();
                break;
            case "AdSoyad":
                _strDeger = _dtAyar.Rows[0]["AdSoyad"].ToString();
                break;
                   
        }
        return _strDeger;
    }

}