using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Otogaleri1
{
    internal class Araç_Kiralama
    {
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-RD4OLNE\\SQLEXPRESS;Initial Catalog=Araç_Kiralama;Integrated Security=True");
        DataTable tablo;
        public void ekle_sil_güncelle(SqlCommand komut,string sorgu)

        {
            baglanti.Open();
            komut.Connection = baglanti;
            komut.CommandText = sorgu;
            komut.ExecuteNonQuery();
            baglanti.Close();
        }
        public DataTable listele(SqlDataAdapter adtr,string sorgu)
        {
            tablo = new DataTable();
            adtr =new SqlDataAdapter(sorgu,baglanti);
            adtr.Fill(tablo);
            baglanti.Close();
            return tablo;
        }
        public void Boş_Araçlar(ComboBox combo,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu,baglanti);
            SqlDataReader read=komut.ExecuteReader();
            while (read.Read())
            {
                combo.Items.Add(read["plaka"].ToString());
            }
            baglanti.Close();
        }
        public void TC_Ara(TextBox tcara,TextBox tc,TextBox adsoyad,TextBox telefon ,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                tc.Text = read["tc"].ToString();
                telefon.Text = read["telefon"].ToString();
                telefon.Text = read["telefon"].ToString();
            }
            baglanti.Close();
        }
        public void Ücret_Hesapla(ComboBox combokiraşekli,TextBox ücret, string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                if (combokiraşekli.SelectedIndex == 0) ücret.Text = (int.Parse(read["ücret"].ToString()) * 1).ToString();
                if (combokiraşekli.SelectedIndex == 1) ücret.Text = (int.Parse(read["ücret"].ToString()) * 0.80).ToString();   
                if (combokiraşekli.SelectedIndex == 2) ücret.Text = (int.Parse(read["ücret"].ToString()) * 0.70).ToString();
                if (combokiraşekli.SelectedIndex == 3) ücret.Text = (int.Parse(read["ücret"].ToString()).ToString()); 
            }
            baglanti.Close();
        }
        public void CombodanGetir(ComboBox araclar ,TextBox marka, TextBox seri, TextBox yıl, TextBox renk ,string sorgu)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand(sorgu, baglanti);
            SqlDataReader read = komut.ExecuteReader();
            while (read.Read())
            {
                marka.Text = read["marka"].ToString();
                seri.Text = read["seri"].ToString();
                yıl.Text = read["yıl"].ToString();
                renk.Text = read["renk"].ToString();
            }
            baglanti.Close();
        }
        public void satışhesapla( Label lbl )
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("select  sum(tutar) from satış",baglanti);
            lbl.Text = "Toplam Tutar="+komut.ExecuteScalar()+"TL";
            baglanti.Close();
        }
    }
}
