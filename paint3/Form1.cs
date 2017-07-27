using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace paint3
{
    public partial class Paint : Form
    {


     

        public Paint()
        {
            InitializeComponent();
        }

        Pen pioro = new Pen(Color.Black, 5);
        bool rysowanierozpoczete = false;
        Point poczatek = new Point(0, 0);
        Point koniec = new Point(0, 0);
        Graphics g;
        int figura = 1; //figury: 1 - rysowanie 2 - kolo 3 - kwadrat 4 - linia

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pioro.Color = button1.BackColor;

        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            rysowanierozpoczete = false;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void Paint_Load(object sender, EventArgs e)
        {
            g = panel1.CreateGraphics();
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            poczatek = e.Location;
            if (e.Button == MouseButtons.Left)
                rysowanierozpoczete = true;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (rysowanierozpoczete)
            koniec = e.Location;
            g = panel1.CreateGraphics();
            g.DrawLine(pioro, poczatek, koniec);
            poczatek = koniec;




        }



        private void button9_Click(object sender, EventArgs e)
        {
            figura = 1;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            figura = 2;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            figura = 4;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            figura = 4;
            pioro.Width = 10;
            string grubosclabel = pioro.Width.ToString();
            label2.Text = grubosclabel;

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Paint v. 0.3 \n by mlawicki \n github.com/mlawicki");
        }

        private void nowyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Refresh();
        }

        private void otwórzToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp)|*.jpg; *.jpeg; *.gif; *.bmp";
            if (open.ShowDialog() == DialogResult.OK)
            {
                panel1.BackgroundImage = Image.FromFile(open.FileName);
                panel1.BackgroundImageLayout = ImageLayout.Stretch;

            }

            else
                System.Windows.Forms.MessageBox.Show("nie udało się otworzyć obrazka");


        }

        private void koniecToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void zapiszToolStripMenuItem_Click(object sender, EventArgs e)
        {

                    System.Windows.Forms.MessageBox.Show("Funkcja jeszcze nieobslugiwana");


        }



        private void button1_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button1.BackColor;
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button2.BackColor;
        }


        private void button3_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button3.BackColor;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button4.BackColor;
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button5.BackColor;
        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button6.BackColor;
        }

        private void button7_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button7.BackColor;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            pioro.Color = button8.BackColor;
        }



        private void button14_Click(object sender, EventArgs e)
        {
            if (pioro.Width >= 100)
                label2.Text = "100";
            else
            {
                pioro.Width += 5;
                string grubosclabel = pioro.Width.ToString();
                label2.Text = grubosclabel;
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            if (pioro.Width <= 1)
                label2.Text = "1";

            else
            {
                pioro.Width -= 5;
                string grubosclabel = pioro.Width.ToString();
                label2.Text = grubosclabel;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
