using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using info.lundin.math;
using System.Drawing;
using System.Collections;

namespace plotter
{
    public class function
    {
        public string equation
        {
            get;
            set;
        }

        public bool showAreaBelow
        {
            get;
            set;
        }

        public Color color
        {
            get;
            set;
        }

        List<PointF> points;

        ExpressionParser parser = new ExpressionParser();

        public function(string equation, Color color)
        {
            this.color = color;
            this.equation = equation;
            this.calcPoints();
        }

        public function(string equation)
        {
            this.color = Color.Black;
            this.equation = equation;
            this.calcPoints();
        }

        private void calcPoints()
        {
            this.points = new List<PointF>();
            this.equation = equation;
            Hashtable varTable = new Hashtable();
            varTable.Add("x", 0.ToString());
            for (float i = -100; i <= 100; i = i + 0.05f)
            {
                varTable["x"] = i.ToString();
                FlippedPointF newPoint = new FlippedPointF(0, 0);
                newPoint.X = i;

                double tempY = parser.Parse(equation, varTable);
                if (Double.IsNaN(tempY))
                {
                    continue;
                }

                newPoint.Y = (float)tempY;
                this.points.Add(newPoint.toPoint());
            }
        }

        public void Draw(Graphics g)
        {
            Pen pen = new Pen(this.color, -1);

            Color clrOp = Color.FromArgb(128, this.color);
            Pen areaPen = new Pen(clrOp, -1);

            g.DrawLines(pen, points.ToArray());
            if (showAreaBelow)
            {
                foreach (PointF p in points)
                {
                    g.DrawLine(areaPen, p, new PointF(p.X, 0));
                }
            }
        }

        public override string ToString()
        {
            return "y=" + this.equation;
        }
    }
}
