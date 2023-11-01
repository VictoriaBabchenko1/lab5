using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lab5_WinFormsApp
{
    class Circle : Figure
    {
        protected int radius;

        public Circle(int centerX, int centerY, int radius)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.radius = radius;
        }

        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(Pens.Black, centerX - radius, centerY - radius, 2 * radius, 2 * radius);
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawEllipse(new Pen(Form1.ActiveForm.BackColor), centerX - radius, centerY - radius, 2 * radius, 2 * radius);
        }
    }
}
