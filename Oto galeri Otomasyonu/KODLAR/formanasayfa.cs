namespace Otogaleri1
{
    public partial class formanasayfa : Form
    {
        public formanasayfa()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            müþteriekle ekle =new müþteriekle();
            ekle.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAraçListele listele =new frmAraçListele();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMüþteriListele listele =new frmMüþteriListele(); 
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAraçkayýt kayýt =new frmAraçkayýt();
            kayýt.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmSözleþme sözleþme =new frmSözleþme();
            sözleþme.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSatýþ satýþ=new frmSatýþ();
            satýþ.ShowDialog();
        }
    }
}