namespace Test_Projesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int dogru = 0, yanlis = 0, soru = 0;

        private void button4_Click(object sender, EventArgs e)
        {
            label8.Text = button4.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (label8.Text == label7.Text)
            {
                pictureBox1.Visible = true;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label8.Text = button3.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (label8.Text == label7.Text)
            {
                pictureBox1.Visible = true;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label8.Text = button2.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (label8.Text == label7.Text)
            {
                pictureBox1.Visible = true;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label8.Text = button1.Text;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = true;
            if (label8.Text == label7.Text)
            {
                pictureBox1.Visible = true;
                dogru++;
                label5.Text = dogru.ToString();
            }
            else
            {
                yanlis++;
                label6.Text = yanlis.ToString();
                pictureBox2.Visible = true;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            soru++;
            label4.Text = soru.ToString();
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            if (soru == 1)
            {
                richTextBox1.Text = "TBMM ne zaman kurulmu�tur?";
                button1.Text = "1920";
                button2.Text = "1921";
                button3.Text = "1922";
                button4.Text = "1923";
                label7.Text = "1920";
                button5.Text = "Sonraki Soru";
                
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            if (soru == 2)
            {
                richTextBox1.Text = "80 darbesinin sorumlusu kimdir?";
                button1.Text = "Cemal G�rsel";
                button2.Text = "Alparslan T�rke�";
                button3.Text = "Kenan Evren";
                button4.Text = "Turgut �zal";
                label7.Text = "Kenan Evren";
                button5.Text = "Sonraki Soru";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            if (soru == 3)
            {
                richTextBox1.Text = "Hangi il Marmara B�lgesinde bulunmaz?";
                button1.Text = "Yalova";
                button2.Text = "Eski�ehir";
                button3.Text = "Bal�kesir";
                button4.Text = "K�rklareli";
                label7.Text = "Eski�ehir";
                button5.Text = "Sonraki Soru";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            if (soru == 4)
            {
                richTextBox1.Text = "Osmanl� 1.Balkan Sava�lar�nda hangi devletle sava�mam��t�r?";
                button1.Text = "S�rbistan";
                button2.Text = "Arnavutluk";
                button3.Text = "Karada�";
                button4.Text = "Yunanistan";
                label7.Text = "Arnavutluk";
                button5.Text = "Sonraki Soru";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            if (soru == 5)
            {
                richTextBox1.Text = "T�rk tarihinde �ift kartal sembol� olan olan devlet hangisidir?";
                button1.Text = "Asya Hun Devleti";
                button2.Text = "G�kt�rk Devleti";
                button3.Text = "Harzem�ahlar";
                button4.Text = "Sel�uklular";
                label7.Text = "Sel�uklular";
                button5.Text = "Sonland�r";
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = false;
            }
            if(soru == 6)
            {
                MessageBox.Show("Do�ru: " + dogru + "\n" + "Yanl��: " + yanlis);
            }
        }
    }
}