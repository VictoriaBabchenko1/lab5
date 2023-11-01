using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lab5_WinFormsApp
{
    class Square : Figure
    {
        protected int sideLength;

        public Square(int centerX, int centerY, int sideLength)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.sideLength = sideLength;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
                new Point(centerX - sideLength / 2,  centerY - sideLength / 2),
                new Point(centerX - sideLength / 2,  centerY + sideLength / 2),
                new Point(centerX + sideLength / 2,  centerY + sideLength / 2),
                new Point(centerX + sideLength / 2,  centerY - sideLength / 2),
            };
        }
        public override void DrawBlack()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(Pens.Black, GetCurrPoints());
        }

        public override void HideDrawingBackGround()
        {
            Graphics graphics = Form1.ActiveForm.CreateGraphics();
            graphics.DrawPolygon(new Pen(Form1.ActiveForm.BackColor), GetCurrPoints());
        }
    }
}
