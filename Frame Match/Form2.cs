using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Frame_Match
{
    public partial class F2 : Form
    {
      
        public F2()
        {
            InitializeComponent();

          
        }

        private void F2_Load(object sender, EventArgs e)
        {
           
        }

        private void F2_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();///this line is for auto close all from when u close any from 
        }

        private void lable_click(object sender, EventArgs e)
        {
     

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            pictureBox7.Visible = true;
            Random random1 = new Random(); //this is the library method to generate a random number
            int randno = random1.Next(1, 3);//the variable randno will get a random value between 0, 1, 2, 3, 4, 5
            pictureBox7.Text = Convert.ToString(randno);
            if (randno == 1)
            {
                pictureBox7.Image = Resource1.thor;
            }
            if (randno == 2)
            {
                pictureBox7.Image = Resource1.iron;
            }
            if (randno == 3)
            {
                pictureBox7.Image = Resource1.cap;
            }
            
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            pictureBox8.Visible = true;
            Random random1 = new Random(); //this is the library method to generate a random number
            int randno = random1.Next(1,4);//the variable randno will get a random value between 0, 1, 2, 3, 4, 5
            pictureBox8.Text = Convert.ToString(randno);
            if (randno == 1)
            {
                pictureBox8.Image = Resource1.thor;
            }
            if (randno == 2)
            {
                pictureBox8.Image = Resource1.iron;
            }
            if (randno == 3)
            {
                pictureBox8.Image = Resource1.cap;
            }

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            pictureBox9.Visible = true;
            Random random1 = new Random(); //this is the library method to generate a random number
            int randno = random1.Next(1, 4);//the variable randno will get a random value between 0, 1, 2, 3, 4, 5
            pictureBox9.Text = Convert.ToString(randno);
            if (randno == 1)
            {
                pictureBox9.Image = Resource1.thor;
            }
            if (randno == 2)
            {
                pictureBox9.Image = Resource1.iron;
            }
            if (randno == 3)
            {
                pictureBox9.Image = Resource1.cap;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
