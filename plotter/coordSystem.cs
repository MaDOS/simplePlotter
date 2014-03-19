using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace plotter
{
    public class coordSystem
    {
        List<function> functions;

        public coordSystem()
        {
            functions = new List<function>();
        }

        public void Draw(Graphics g, int pixelBounds)
        {
            Pen pen = new Pen(Color.Black, -1);
            Font font = new Font(FontFamily.GenericMonospace, 0.45f);
            g.DrawLine(pen, new Point(0 - pixelBounds, 0), new Point(0 + pixelBounds, 0));
            g.DrawLine(pen, new Point(0, 0 - pixelBounds), new Point(0, 0 + pixelBounds));
            for (int x = -100; x <= 100; x++)
            {
                g.DrawString(x.ToString(), font, pen.Brush, new Point(x, 0));
            }
            for (int y = -100; y <= 100; y++)
            {
                if (y != 0)
                {
                    g.DrawString(y.ToString(), font, pen.Brush, new FlippedPointF(0, (y + 0.5f)).toPoint());
                }
            }

            foreach (function f in functions)
            {
                f.Draw(g);
            }
        }

        public void addFunction(function f)
        {
            functions.Add(f);
        }

        public void removeFunction(function f)
        {
            functions.Remove(f);
        }
    }
}
