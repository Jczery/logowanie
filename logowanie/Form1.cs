using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace logowanie
{
    public partial class Form1 : Form
    {
        int index=0;
        string[] odpowiedzi;
        string odpowiedz;
        Bitmap[] zdjecia;
        Form2 form2 = new Form2();

        public Form1()
        {
            InitializeComponent();
            zdjecia = new Bitmap[7];
            odpowiedzi = new string[7];

            zdjecia[0] = logowanie.Properties.Resources._1;
            zdjecia[1] = logowanie.Properties.Resources._2;
            zdjecia[2] = logowanie.Properties.Resources._3;
            zdjecia[3] = logowanie.Properties.Resources._4;
            zdjecia[4] = logowanie.Properties.Resources._5;
            zdjecia[5] = logowanie.Properties.Resources._6;
            zdjecia[6] = logowanie.Properties.Resources._7;

            odpowiedzi[0] = "mxyxw";
            odpowiedzi[1] = "b5nmm";
            odpowiedzi[2] = "74853";
            odpowiedzi[3] = "cg5dd";
            odpowiedzi[4] = "x3deb";
            odpowiedzi[5] = "befhd";
            odpowiedzi[6] = "c7gb3";

            losujNoweZdjecie();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (validate())
            {
                form2.Show();
                this.Hide();
            }
        }
        private bool validate()
        {
            return textBox1.Text.ToString() == "admin" && textBox2.Text.ToString() == "Qwerty1@34" && textBox3.Text.ToString() == odpowiedz ? true : false;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
        }

        private void losujNowy_Click(object sender, EventArgs e)
        {
            losujNoweZdjecie();
        }
        private void losujNoweZdjecie()
        {
            Random rnd = new Random();
            int newIndex = rnd.Next(0, 7);
            while (newIndex == index)
            {
                newIndex = rnd.Next(0, 7);
            }
            index = newIndex;
            pictureBox1.Image = zdjecia[index];
            odpowiedz = odpowiedzi[index];
        }
    }
}
