using System;
using System.Windows;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Controls;


namespace ClassLibrary
{
    public static class DbIslem
    {

        static SqlConnection baglanti = new SqlConnection(@"Server=X870\SQLEXPRESS;Database=NotDb;Integrated Security = True");


        public static void Baglan()
        {
            if (baglanti.State == ConnectionState.Closed)
            {
                baglanti.Open();
            }
        }

        public static void Ekle(string dbtabloadi, string dbkolon, string dbdeger)
        {
            Baglan();
            string ekleString = "INSERT INTO " + dbtabloadi + "(" + dbkolon + ") VALUES(" + dbdeger + ")";
            SqlCommand eklesql = new SqlCommand(ekleString, baglanti); //
            int etkilenensatirsayisi = eklesql.ExecuteNonQuery();
            baglanti.Close();
           
           
        }

        public static void Duzelt(string dbtabloadi, string dbkolonadi, string dbkolondeger, string id)
        {
            Baglan();
            string duzeltString = "UPDATE " + dbtabloadi + " SET " + dbkolonadi + "=('" + dbkolondeger + "') WHERE id =('" + id + "')";
            SqlCommand duzeltsql = new SqlCommand(duzeltString, baglanti);
            duzeltsql.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void Sil(string dbtabloadi, string id)
        {
            Baglan();
            string silString = "DELETE FROM " + dbtabloadi + " WHERE id =('" + id + "')";
            SqlCommand silsql = new SqlCommand(silString, baglanti);
            silsql.ExecuteNonQuery();
            baglanti.Close();
        }

        public static void Ara(DataGrid dataGrid,string dbtabloadi,string dbkolonadi)
        {
            Baglan();
            string araString = "SELECT "+dbkolonadi+" FROM " + dbtabloadi;
            SqlCommand arasql = new SqlCommand(araString, baglanti);
            SqlDataAdapter sqlData = new SqlDataAdapter(arasql);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            baglanti.Close();
        }
        public static void ComboAra(DataGrid dataGrid, string dbtabloadi, string dbkolonadi, string sartkolonu, string sart)
        {
            Baglan();
            string araString = "SELECT " + dbkolonadi + " FROM " + dbtabloadi + " where " + sartkolonu + "=" + sart;
            SqlCommand arasql = new SqlCommand(araString, baglanti);
            SqlDataAdapter sqlData = new SqlDataAdapter(arasql);
            DataTable dt = new DataTable();
            sqlData.Fill(dt);
            dataGrid.ItemsSource = dt.DefaultView;
            baglanti.Close();
        }
        public static void CbDoldur(ComboBox cb, string cbTablo, string cbKolonAdi)
        {
            Baglan();
            SqlCommand cmd = new SqlCommand("select * from " +cbTablo , baglanti);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                cb.Items.Add(dr[cbKolonAdi]);
            }
            baglanti.Close();
        }
        
    }
}
