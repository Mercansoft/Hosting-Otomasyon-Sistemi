using System;
using System.Collections.Generic;
using System.Web;
using System.Data;
using System.Data.OleDb;

/// <summary>
/// Summary description for Data
/// </summary>
public class Data
{

	public Data()
	{
		//
		// TODO: Add constructor logic here
		//
	}
    public bool _fncExecuteNonQuery(string SqlSorgu)
    {
        bool sorgu = true;
        try
        {
            OleDbConnection _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            OleDbCommand _cmd = new OleDbCommand(SqlSorgu, _cnn);
            _cmd.ExecuteNonQuery();
            _cnn.Close();
        }
        catch (Exception)
        {
            sorgu = false;
        }
        return sorgu;
    }
    public DataTable _fncSelect(string SqlSorgu)
    {
        DataTable _dtData = new DataTable();
        try
        {

            //string Baglan = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
            OleDbConnection _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            OleDbCommand _cmd = new OleDbCommand(SqlSorgu, _cnn);
            OleDbDataAdapter _da = new OleDbDataAdapter(_cmd);
            _da.Fill(_dtData);
            _cnn.Close();
        }
        catch (Exception)
        {
            _dtData = null;
        }
        return _dtData;
    }
    public bool _fncBoolLogin(string SqlSorgu)
    {
        OleDbConnection _cnn = new OleDbConnection(Baglan);
        bool deger =false;
        try
        {
           
            _cnn.Open();
            OleDbCommand _cmd = new OleDbCommand(SqlSorgu, _cnn);
            string sayi = _cmd.ExecuteScalar().ToString();
            if (Convert.ToInt32(_cmd.ExecuteScalar())==1)
            {
                deger = true;
            }
            
        }
        catch (Exception)
        {
            deger = false;
        }
        _cnn.Close();
        return deger;
    }
    public string _fncSelectString(string SqlSorgu)
    {
        DataTable _dtUrunAdi = new DataTable();
        try
        {

            //string Baglan = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
            OleDbConnection _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            OleDbCommand _cmd = new OleDbCommand(SqlSorgu, _cnn);
            OleDbDataAdapter _da = new OleDbDataAdapter(_cmd);
            _da.Fill(_dtUrunAdi);
            _cnn.Close();
            _deger = _dtUrunAdi.Rows[0].ItemArray[0].ToString();
        }
        catch (Exception)
        {
            _deger = "";
        }
        return _deger;
    }
    public OleDbDataReader _fncDataReader(string SqlSorgu)
    {
        OleDbDataReader _rd;
        try
        {

            //string Baglan = "Provider=Microsoft.Jet.OleDb.4.0; Data Source=" + Server.MapPath("~/App_Data\\MercanYazilimDataBase.mdb");
            OleDbConnection _cnn = new OleDbConnection(Baglan);
            _cnn.Open();
            OleDbCommand _cmd = new OleDbCommand(SqlSorgu, _cnn);
            _rd = _cmd.ExecuteReader();
        }
        catch (Exception)
        {
            _rd = null;
        }
        return _rd;
    }
}