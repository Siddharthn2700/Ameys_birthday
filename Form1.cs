using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech.Synthesis;
using System.Threading;

namespace DrugDealer_birthday
{
    public partial class Form1 : Form
    {
        SpeechSynthesizer synth = new SpeechSynthesizer();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Hide();
            pictureBox1.Show();
            pictureBox2.Show();
            pictureBox3.Show();
            pictureBox4.Show();
            textBox1.Show();
            System.Media.SoundPlayer player = new System.Media.SoundPlayer(@"C:\coding\lezgo.wav");
            player.PlaySync();
            //Thread.Sleep(2000);
            //synth.SpeakAsync("Many many happy returns of the day Amey. Hope you like this little surprise. A tribute to our friendship");
            synth.SpeakAsync("Many many happy returns of the day Amey. I Siddharth wishes you the best of luck in your computer science career");
            
        }
    }
}
