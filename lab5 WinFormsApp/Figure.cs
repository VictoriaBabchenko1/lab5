using System;
using System.Collections.Generic;
using System.Text;

namespace lab5_WinFormsApp
{
    abstract class Figure
    {
        protected int centerX;
        protected int centerY;

        public abstract void DrawBlack();
        public abstract void HideDrawingBackGround();
        public void MoveRight()
        {
            for (int i = 0; i < 200; i++)
            {
                DrawBlack();
                System.Threading.Thread.Sleep(100);
                HideDrawingBackGround();
                centerX++;
            }
        }
    }
}
