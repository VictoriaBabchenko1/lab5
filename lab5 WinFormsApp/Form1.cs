using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab5_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Square square = new Square(150, 200, 200);
            square.MoveRight();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Circle circle = new Circle(150, 200, 100);
            circle.MoveRight();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Romb romb = new Romb(150, 200, 200, 200);
            romb.MoveRight();
        }
    }
}
