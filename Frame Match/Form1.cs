using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Frame_Match
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SoundPlayer sound = new SoundPlayer(Resource1.Enter);
            sound.Play();

            F2 F2 = new F2();  ///this line is givine as define a form 2 page 
            this.Hide();  ///this line is here auto hide form 1 page after clicking enter but not closing it 
            F2.ShowDialog(); ///this line to popup form 2
        }
    }
}
