using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace lab5_WinFormsApp
{
    class Romb : Figure
    {
        protected int horDiagLen;
        protected int verDiagLen;

        public Romb(int centerX, int centerY, int horDiagLen, int verDiagLen)
        {
            this.centerX = centerX;
            this.centerY = centerY;
            this.horDiagLen = horDiagLen;
            this.verDiagLen = verDiagLen;
        }

        private Point[] GetCurrPoints()
        {
            return new Point[] {
            new Point(centerX, centerY - verDiagLen / 2),
            new Point(centerX - horDiagLen / 2, centerY),
            new Point(centerX, centerY + verDiagLen / 2),
            new Point(centerX + horDiagLen / 2, centerY),
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
