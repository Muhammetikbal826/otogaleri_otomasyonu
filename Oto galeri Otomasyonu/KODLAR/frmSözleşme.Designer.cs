namespace Otogaleri1
{
    partial class frmSözleşme
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSözleşme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtTcAra = new System.Windows.Forms.TextBox();
            this.txtE_Yer = new System.Windows.Forms.TextBox();
            this.txtE_Tarih = new System.Windows.Forms.TextBox();
            this.txtE_No = new System.Windows.Forms.TextBox();
            this.txtTelefon = new System.Windows.Forms.TextBox();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.txtTc = new System.Windows.Forms.TextBox();
            this.lblE_Yer = new System.Windows.Forms.Label();
            this.lblE_Tarih = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.dateDönüş = new System.Windows.Forms.DateTimePicker();
            this.dateÇıkış = new System.Windows.Forms.DateTimePicker();
            this.txtTutar = new System.Windows.Forms.TextBox();
            this.txtGün = new System.Windows.Forms.TextBox();
            this.txtKiraÜcreti = new System.Windows.Forms.TextBox();
            this.txtRenk = new System.Windows.Forms.TextBox();
            this.txtYıl = new System.Windows.Forms.TextBox();
            this.txtSeri = new System.Windows.Forms.TextBox();
            this.txtMarka = new System.Windows.Forms.TextBox();
            this.comboKiraŞekli = new System.Windows.Forms.ComboBox();
            this.comboAraçlar = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnGüncelle = new System.Windows.Forms.Button();
            this.btnAraçTeslim = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.txtEkstra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox1.BackgroundImage")));
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Controls.Add(this.txtTcAra);
            this.groupBox1.Controls.Add(this.txtE_Yer);
            this.groupBox1.Controls.Add(this.txtE_Tarih);
            this.groupBox1.Controls.Add(this.txtE_No);
            this.groupBox1.Controls.Add(this.txtTelefon);
            this.groupBox1.Controls.Add(this.txtAdSoyad);
            this.groupBox1.Controls.Add(this.txtTc);
            this.groupBox1.Controls.Add(this.lblE_Yer);
            this.groupBox1.Controls.Add(this.lblE_Tarih);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 278);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Müşteri Bilgileri";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label18.ForeColor = System.Drawing.Color.MistyRose;
            this.label18.Location = new System.Drawing.Point(43, 45);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(68, 20);
            this.label18.TabIndex = 15;
            this.label18.Text = "TC ARA:";
            // 
            // txtTcAra
            // 
            this.txtTcAra.BackColor = System.Drawing.Color.MistyRose;
            this.txtTcAra.Location = new System.Drawing.Point(122, 42);
            this.txtTcAra.Name = "txtTcAra";
            this.txtTcAra.Size = new System.Drawing.Size(126, 27);
            this.txtTcAra.TabIndex = 14;
            this.txtTcAra.TextChanged += new System.EventHandler(this.txtTcAra_TextChanged);
            // 
            // txtE_Yer
            // 
            this.txtE_Yer.BackColor = System.Drawing.Color.MistyRose;
            this.txtE_Yer.Location = new System.Drawing.Point(122, 245);
            this.txtE_Yer.Name = "txtE_Yer";
            this.txtE_Yer.Size = new System.Drawing.Size(126, 27);
            this.txtE_Yer.TabIndex = 13;
            // 
            // txtE_Tarih
            // 
            this.txtE_Tarih.BackColor = System.Drawing.Color.MistyRose;
            this.txtE_Tarih.Location = new System.Drawing.Point(122, 211);
            this.txtE_Tarih.Name = "txtE_Tarih";
            this.txtE_Tarih.Size = new System.Drawing.Size(126, 27);
            this.txtE_Tarih.TabIndex = 12;
            // 
            // txtE_No
            // 
            this.txtE_No.BackColor = System.Drawing.Color.MistyRose;
            this.txtE_No.Location = new System.Drawing.Point(122, 177);
            this.txtE_No.Name = "txtE_No";
            this.txtE_No.Size = new System.Drawing.Size(126, 27);
            this.txtE_No.TabIndex = 11;
            // 
            // txtTelefon
            // 
            this.txtTelefon.BackColor = System.Drawing.Color.MistyRose;
            this.txtTelefon.Location = new System.Drawing.Point(122, 143);
            this.txtTelefon.Name = "txtTelefon";
            this.txtTelefon.Size = new System.Drawing.Size(126, 27);
            this.txtTelefon.TabIndex = 10;
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.BackColor = System.Drawing.Color.MistyRose;
            this.txtAdSoyad.Location = new System.Drawing.Point(122, 109);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(126, 27);
            this.txtAdSoyad.TabIndex = 9;
            // 
            // txtTc
            // 
            this.txtTc.BackColor = System.Drawing.Color.MistyRose;
            this.txtTc.Location = new System.Drawing.Point(122, 75);
            this.txtTc.Name = "txtTc";
            this.txtTc.Size = new System.Drawing.Size(126, 27);
            this.txtTc.TabIndex = 8;
            this.txtTc.TextChanged += new System.EventHandler(this.txtTc_TextChanged);
            // 
            // lblE_Yer
            // 
            this.lblE_Yer.AutoSize = true;
            this.lblE_Yer.BackColor = System.Drawing.Color.Transparent;
            this.lblE_Yer.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblE_Yer.ForeColor = System.Drawing.Color.MistyRose;
            this.lblE_Yer.Location = new System.Drawing.Point(0, 248);
            this.lblE_Yer.Name = "lblE_Yer";
            this.lblE_Yer.Size = new System.Drawing.Size(114, 20);
            this.lblE_Yer.TabIndex = 7;
            this.lblE_Yer.Text = "E_verildiği Yer:";
            // 
            // lblE_Tarih
            // 
            this.lblE_Tarih.AutoSize = true;
            this.lblE_Tarih.BackColor = System.Drawing.Color.Transparent;
            this.lblE_Tarih.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.lblE_Tarih.ForeColor = System.Drawing.Color.MistyRose;
            this.lblE_Tarih.Location = new System.Drawing.Point(9, 214);
            this.lblE_Tarih.Name = "lblE_Tarih";
            this.lblE_Tarih.Size = new System.Drawing.Size(109, 20);
            this.lblE_Tarih.TabIndex = 6;
            this.lblE_Tarih.Text = "Ehliyet Tarihi:";
            this.lblE_Tarih.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.MistyRose;
            this.label4.Location = new System.Drawing.Point(24, 180);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(87, 20);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ehliyet No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.MistyRose;
            this.label3.Location = new System.Drawing.Point(43, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Telefon:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.MistyRose;
            this.label2.Location = new System.Drawing.Point(28, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "Ad Soyad:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.MistyRose;
            this.label1.Location = new System.Drawing.Point(76, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "TC:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.MistyRose;
            this.groupBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("groupBox2.BackgroundImage")));
            this.groupBox2.Controls.Add(this.btnHesapla);
            this.groupBox2.Controls.Add(this.dateDönüş);
            this.groupBox2.Controls.Add(this.dateÇıkış);
            this.groupBox2.Controls.Add(this.txtTutar);
            this.groupBox2.Controls.Add(this.txtGün);
            this.groupBox2.Controls.Add(this.txtKiraÜcreti);
            this.groupBox2.Controls.Add(this.txtRenk);
            this.groupBox2.Controls.Add(this.txtYıl);
            this.groupBox2.Controls.Add(this.txtSeri);
            this.groupBox2.Controls.Add(this.txtMarka);
            this.groupBox2.Controls.Add(this.comboKiraŞekli);
            this.groupBox2.Controls.Add(this.comboAraçlar);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label14);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Location = new System.Drawing.Point(256, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(609, 278);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Araç Bilgileri";
            // 
            // btnHesapla
            // 
            this.btnHesapla.BackColor = System.Drawing.Color.LightCoral;
            this.btnHesapla.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnHesapla.Location = new System.Drawing.Point(509, 66);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(94, 102);
            this.btnHesapla.TabIndex = 23;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = false;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // dateDönüş
            // 
            this.dateDönüş.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dateDönüş.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateDönüş.Location = new System.Drawing.Point(381, 214);
            this.dateDönüş.Name = "dateDönüş";
            this.dateDönüş.Size = new System.Drawing.Size(125, 27);
            this.dateDönüş.TabIndex = 22;
            // 
            // dateÇıkış
            // 
            this.dateÇıkış.CalendarMonthBackground = System.Drawing.Color.MistyRose;
            this.dateÇıkış.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateÇıkış.Location = new System.Drawing.Point(381, 166);
            this.dateÇıkış.Name = "dateÇıkış";
            this.dateÇıkış.Size = new System.Drawing.Size(125, 27);
            this.dateÇıkış.TabIndex = 2;
            // 
            // txtTutar
            // 
            this.txtTutar.BackColor = System.Drawing.Color.MistyRose;
            this.txtTutar.Location = new System.Drawing.Point(381, 126);
            this.txtTutar.Name = "txtTutar";
            this.txtTutar.Size = new System.Drawing.Size(125, 27);
            this.txtTutar.TabIndex = 21;
            // 
            // txtGün
            // 
            this.txtGün.BackColor = System.Drawing.Color.MistyRose;
            this.txtGün.Location = new System.Drawing.Point(381, 78);
            this.txtGün.Name = "txtGün";
            this.txtGün.Size = new System.Drawing.Size(125, 27);
            this.txtGün.TabIndex = 20;
            // 
            // txtKiraÜcreti
            // 
            this.txtKiraÜcreti.BackColor = System.Drawing.Color.MistyRose;
            this.txtKiraÜcreti.Location = new System.Drawing.Point(381, 36);
            this.txtKiraÜcreti.Name = "txtKiraÜcreti";
            this.txtKiraÜcreti.Size = new System.Drawing.Size(125, 27);
            this.txtKiraÜcreti.TabIndex = 19;
            this.txtKiraÜcreti.TextChanged += new System.EventHandler(this.txtKiraÜcreti_TextChanged);
            // 
            // txtRenk
            // 
            this.txtRenk.BackColor = System.Drawing.Color.MistyRose;
            this.txtRenk.Location = new System.Drawing.Point(106, 180);
            this.txtRenk.Name = "txtRenk";
            this.txtRenk.Size = new System.Drawing.Size(125, 27);
            this.txtRenk.TabIndex = 18;
            // 
            // txtYıl
            // 
            this.txtYıl.BackColor = System.Drawing.Color.MistyRose;
            this.txtYıl.Location = new System.Drawing.Point(106, 141);
            this.txtYıl.Name = "txtYıl";
            this.txtYıl.Size = new System.Drawing.Size(125, 27);
            this.txtYıl.TabIndex = 17;
            this.txtYıl.TextChanged += new System.EventHandler(this.txtYıl_TextChanged);
            // 
            // txtSeri
            // 
            this.txtSeri.BackColor = System.Drawing.Color.MistyRose;
            this.txtSeri.Location = new System.Drawing.Point(106, 105);
            this.txtSeri.Name = "txtSeri";
            this.txtSeri.Size = new System.Drawing.Size(125, 27);
            this.txtSeri.TabIndex = 16;
            // 
            // txtMarka
            // 
            this.txtMarka.BackColor = System.Drawing.Color.MistyRose;
            this.txtMarka.Location = new System.Drawing.Point(106, 69);
            this.txtMarka.Name = "txtMarka";
            this.txtMarka.Size = new System.Drawing.Size(125, 27);
            this.txtMarka.TabIndex = 15;
            this.txtMarka.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // comboKiraŞekli
            // 
            this.comboKiraŞekli.BackColor = System.Drawing.Color.MistyRose;
            this.comboKiraŞekli.FormattingEnabled = true;
            this.comboKiraŞekli.Items.AddRange(new object[] {
            "GÜNLÜK",
            "HAFTALIK",
            "AYLIK ",
            "SATIŞ"});
            this.comboKiraŞekli.Location = new System.Drawing.Point(106, 218);
            this.comboKiraŞekli.Name = "comboKiraŞekli";
            this.comboKiraŞekli.Size = new System.Drawing.Size(125, 28);
            this.comboKiraŞekli.TabIndex = 14;
            this.comboKiraŞekli.SelectedIndexChanged += new System.EventHandler(this.txtKiraŞekli_SelectedIndexChanged);
            // 
            // comboAraçlar
            // 
            this.comboAraçlar.BackColor = System.Drawing.Color.MistyRose;
            this.comboAraçlar.FormattingEnabled = true;
            this.comboAraçlar.Location = new System.Drawing.Point(106, 36);
            this.comboAraçlar.Name = "comboAraçlar";
            this.comboAraçlar.Size = new System.Drawing.Size(125, 28);
            this.comboAraçlar.TabIndex = 13;
            this.comboAraçlar.SelectedIndexChanged += new System.EventHandler(this.comboAraçlar_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Transparent;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label17.ForeColor = System.Drawing.Color.MistyRose;
            this.label17.Location = new System.Drawing.Point(274, 219);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(105, 20);
            this.label17.TabIndex = 12;
            this.label17.Text = "Dönüş Tarihi:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Transparent;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label16.ForeColor = System.Drawing.Color.MistyRose;
            this.label16.Location = new System.Drawing.Point(284, 174);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(95, 20);
            this.label16.TabIndex = 11;
            this.label16.Text = "Çıkış Tarihi:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label15.ForeColor = System.Drawing.Color.MistyRose;
            this.label15.Location = new System.Drawing.Point(327, 129);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(52, 20);
            this.label15.TabIndex = 10;
            this.label15.Text = "Tutar:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label14.ForeColor = System.Drawing.Color.MistyRose;
            this.label14.Location = new System.Drawing.Point(337, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(42, 20);
            this.label14.TabIndex = 9;
            this.label14.Text = "Gün:";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label13.ForeColor = System.Drawing.Color.MistyRose;
            this.label13.Location = new System.Drawing.Point(289, 39);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(90, 20);
            this.label13.TabIndex = 8;
            this.label13.Text = "Kira Ücreti:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Transparent;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label12.ForeColor = System.Drawing.Color.MistyRose;
            this.label12.Location = new System.Drawing.Point(19, 221);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(81, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Kira Şekli:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label11.ForeColor = System.Drawing.Color.MistyRose;
            this.label11.Location = new System.Drawing.Point(52, 185);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Renk:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label10.ForeColor = System.Drawing.Color.MistyRose;
            this.label10.Location = new System.Drawing.Point(43, 149);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(57, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Model:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label9.ForeColor = System.Drawing.Color.MistyRose;
            this.label9.Location = new System.Drawing.Point(60, 113);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 20);
            this.label9.TabIndex = 4;
            this.label9.Text = "Seri:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label8.ForeColor = System.Drawing.Color.MistyRose;
            this.label8.Location = new System.Drawing.Point(42, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 20);
            this.label8.TabIndex = 3;
            this.label8.Text = "Marka:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.Color.MistyRose;
            this.label7.Location = new System.Drawing.Point(34, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(66, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Araçlar:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.MistyRose;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(0, 361);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(884, 345);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentDoubleClick);
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnEkle.ForeColor = System.Drawing.Color.Firebrick;
            this.btnEkle.Location = new System.Drawing.Point(88, 302);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(160, 53);
            this.btnEkle.TabIndex = 23;
            this.btnEkle.Text = "Sözleşme Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnGüncelle
            // 
            this.btnGüncelle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnGüncelle.ForeColor = System.Drawing.Color.Salmon;
            this.btnGüncelle.Location = new System.Drawing.Point(254, 302);
            this.btnGüncelle.Name = "btnGüncelle";
            this.btnGüncelle.Size = new System.Drawing.Size(168, 53);
            this.btnGüncelle.TabIndex = 24;
            this.btnGüncelle.Text = "Sözleşme Güncelle";
            this.btnGüncelle.UseVisualStyleBackColor = true;
            this.btnGüncelle.Click += new System.EventHandler(this.btnGüncelle_Click);
            // 
            // btnAraçTeslim
            // 
            this.btnAraçTeslim.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAraçTeslim.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnAraçTeslim.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAraçTeslim.Location = new System.Drawing.Point(777, 705);
            this.btnAraçTeslim.Name = "btnAraçTeslim";
            this.btnAraçTeslim.Size = new System.Drawing.Size(107, 41);
            this.btnAraçTeslim.TabIndex = 25;
            this.btnAraçTeslim.Text = "Araç Teslim";
            this.btnAraçTeslim.UseVisualStyleBackColor = false;
            this.btnAraçTeslim.Click += new System.EventHandler(this.btnAraçTeslim_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.BackColor = System.Drawing.Color.RosyBrown;
            this.btnTemizle.Font = new System.Drawing.Font("Segoe UI", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.btnTemizle.ForeColor = System.Drawing.Color.LemonChiffon;
            this.btnTemizle.Location = new System.Drawing.Point(677, 296);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(100, 59);
            this.btnTemizle.TabIndex = 26;
            this.btnTemizle.Text = "Temizle";
            this.btnTemizle.UseVisualStyleBackColor = false;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // txtEkstra
            // 
            this.txtEkstra.BackColor = System.Drawing.Color.MistyRose;
            this.txtEkstra.Location = new System.Drawing.Point(563, 716);
            this.txtEkstra.Name = "txtEkstra";
            this.txtEkstra.Size = new System.Drawing.Size(126, 27);
            this.txtEkstra.TabIndex = 28;
            this.txtEkstra.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.Color.IndianRed;
            this.label5.Location = new System.Drawing.Point(375, 719);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 20);
            this.label5.TabIndex = 27;
            this.label5.Text = "Alacak/Verecek Durumu";
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // frmSözleşme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(885, 748);
            this.Controls.Add(this.txtEkstra);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnGüncelle);
            this.Controls.Add(this.btnAraçTeslim);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.Color.NavajoWhite;
            this.Name = "frmSözleşme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sözleşme Sayfası";
            this.Load += new System.EventHandler(this.frmSözleşme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Label lblE_Yer;
        private Label lblE_Tarih;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private GroupBox groupBox2;
        private DataGridView dataGridView1;
        private TextBox txtE_Yer;
        private TextBox txtE_Tarih;
        private TextBox txtE_No;
        private TextBox txtTelefon;
        private TextBox txtAdSoyad;
        private TextBox txtTc;
        private TextBox txtMarka;
        private ComboBox comboKiraŞekli;
        private ComboBox comboAraçlar;
        private Label label17;
        private Label label16;
        private Label label15;
        private Label label14;
        private Label label13;
        private Label label12;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private DateTimePicker dateDönüş;
        private DateTimePicker dateÇıkış;
        private TextBox txtTutar;
        private TextBox txtGün;
        private TextBox txtKiraÜcreti;
        private TextBox txtRenk;
        private TextBox txtYıl;
        private TextBox txtSeri;
        private Button btnEkle;
        private Button btnGüncelle;
        private Button btnAraçTeslim;
        private Button btnHesapla;
        private Button btnTemizle;
        private Label label18;
        private TextBox txtTcAra;
        private TextBox txtEkstra;
        private Label label5;
    }
}