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
            m��teriekle ekle =new m��teriekle();
            ekle.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmAra�Listele listele =new frmAra�Listele();
            listele.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmM��teriListele listele =new frmM��teriListele(); 
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmAra�kay�t kay�t =new frmAra�kay�t();
            kay�t.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmS�zle�me s�zle�me =new frmS�zle�me();
            s�zle�me.ShowDialog();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            frmSat�� sat��=new frmSat��();
            sat��.ShowDialog();
        }
    }
}