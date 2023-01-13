﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otogaleri1
{
    public partial class frmMüşteriListele : Form
    {
        Araç_Kiralama arackiralama=new Araç_Kiralama();
        public frmMüşteriListele()
        {
            InitializeComponent();
        }

        private void frmMüşteriListele_Load(object sender, EventArgs e)
        {
            YenileListele();
        }
        private void YenileListele()
        {
            string cümle = "select *from müşteri";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
            

            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
            dataGridView1.Columns[0].HeaderText = "TC";
            dataGridView1.Columns[1].HeaderText = "AD SOYAD";
            dataGridView1.Columns[2].HeaderText = "TELEFON";
            dataGridView1.Columns[3].HeaderText = "ADRES";
            dataGridView1.Columns[4].HeaderText = "E-MAİL";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string cümle = "select *from müşteri where tc like'%"+textBox1.Text+"%'";
            SqlDataAdapter adtr2 = new SqlDataAdapter();
             
            dataGridView1.DataSource = arackiralama.listele(adtr2, cümle);
        }

        private void btniptal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            txtTC.Text = satır.Cells[0].Value.ToString();
            txtAdSoyad.Text = satır.Cells[1].Value.ToString();
            txtTelefon.Text = satır.Cells[2].Value.ToString();
            txtAdres.Text = satır.Cells[3].Value.ToString();
            txtmail.Text = satır.Cells[4].Value.ToString();

        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            string cümle = "update müşteri set adsoyad=@adsoyad,telefon=@telefon,adres=@adres,email=@email where tc=@tc";
            SqlCommand komut2 = new SqlCommand();
            komut2.Parameters.AddWithValue("@tc", txtTC.Text);
            komut2.Parameters.AddWithValue("@adsoyad", txtAdSoyad.Text);
            komut2.Parameters.AddWithValue("@telefon", txtTelefon.Text);
            komut2.Parameters.AddWithValue("@adres", txtAdres.Text);
            komut2.Parameters.AddWithValue("@email", txtmail.Text);
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            arackiralama.ekle_sil_güncelle(komut2,cümle);
            YenileListele();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow satır = dataGridView1.CurrentRow;
            string cümle = "delete from müşteri where tc='" + satır.Cells["tc"].Value.ToString() + "'";
            SqlCommand komut2=new SqlCommand();
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            foreach (Control item in Controls) if (item is TextBox) item.Text = "";
            arackiralama.ekle_sil_güncelle(komut2, cümle);
            YenileListele();

        }
    }
}
