using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ADI
{
    public partial class Form1 : Form
    {

         int xPos, yPos;
         int speedX=5,speedY =5;



        public Form1()
        {
            InitializeComponent();

        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Location = new Point(Form.ActiveForm.Width / 2, Form.ActiveForm.Height / 2);
            xPos = pictureBox1.Location.X;
            yPos = pictureBox1.Location.Y;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            xPos += speedX;
            yPos += speedY;

            if (xPos <= 0)
            {
                xPos = 0;
                speedX = speedX * -1;
            }

            else if(xPos + pictureBox1.Width > Form.ActiveForm.Width)
            {
                xPos = Form.ActiveForm.Width - pictureBox1.Width;
                speedX = speedX * -1; 
            }

            if (yPos <= 0)
            {
                yPos = 0;
                speedY = speedY * -1;
            }

            else if (yPos + pictureBox1.Height > Form.ActiveForm.Height)
            {
                yPos = Form.ActiveForm.Height-pictureBox1.Height;
                speedY = speedY * -1;
            }

            pictureBox1.Location = new Point(xPos, yPos);
        }
    }
}
