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

        public bool showApproximationRects
        {
            get;
            set;
        }

        public float widthApproximationRects
        {
            get;
            set;
        }

        public float resolution
        {
            get
            {
                return this._resolution;
            }
            set
            {
                this._resolution = value;
                this.calcPoints();
            }
        }

        private float _resolution;

        public Color color
        {
            get;
            set;
        }

        public int areaOpaque
        {
            get
            {
                return this._areaOpaque;
            }
            set
            {
                this._areaOpaque = value;
                Color clrOp = Color.FromArgb(this.areaOpaque, this.color);
                this.areaPen = new Pen(clrOp, -1);
            }
        }

        private int _areaOpaque;

        List<PointF> points;
        ExpressionParser parser = new ExpressionParser();

        private Pen pen;
        private Pen areaPen;

        #region construct

        public function(string equation, Color color)
        {
            this.color = color;
            this.equation = equation;
            this.resolution = 0.05f;
            this.pen = new Pen(this.color, -1);
            this.areaOpaque = 128;
            this.widthApproximationRects = 1;
        }

        public function(string equation)
        {
            this.color = Color.Black;
            this.equation = equation;
            this.resolution = 0.05f;
            this.pen = new Pen(this.color, -1);
            this.areaOpaque = 128;
            this.widthApproximationRects = 1;
        }

        #endregion

        public void calcPoints()
        {
            this.points = new List<PointF>();

            for (float i = -100; i <= 100; i = i + this._resolution)
            {
                FlippedPointF newPoint = new FlippedPointF(0, 0);
                newPoint.X = i;
                newPoint.Y = this.y(i);

                if (Single.IsNaN(newPoint.Y) || Single.IsInfinity(newPoint.Y))
                {
                    continue;
                }

                this.points.Add(newPoint.toPoint());
            }
        }

        public void Draw(Graphics g)
        {
            g.DrawLines(pen, points.ToArray());
            if (showAreaBelow)
            {
                foreach (PointF p in points)
                {
                    g.DrawLine(areaPen, p, new PointF(p.X, 0));
                }
            }
            if (showApproximationRects)
            {
                for (float i = 0; i <= 100; i = i + this.widthApproximationRects)
                {
                    FlippedPointF newPoint = new FlippedPointF(0, 0);
                    newPoint.X = i;
                    newPoint.Y = this.y(i);

                    if (Single.IsNaN(newPoint.Y) || Single.IsInfinity(newPoint.Y))
                    {
                        continue;
                    }

                    g.DrawRectangle(this.areaPen, newPoint.toPoint().X, newPoint.toPoint().Y, this.widthApproximationRects, this.y(i));
                }
                for (float i = 0; i > -100; i = i - this.widthApproximationRects)
                {
                    FlippedPointF newPoint = new FlippedPointF(0, 0);
                    newPoint.X = i;
                    newPoint.Y = this.y(i);

                    if (Single.IsNaN(newPoint.Y) || Single.IsInfinity(newPoint.Y))
                    {
                        continue;
                    }

                    g.DrawRectangle(this.areaPen, newPoint.toPoint().X - this.widthApproximationRects, newPoint.toPoint().Y, this.widthApproximationRects, this.y(i));
                }
            }
        }

        public float y(float x)
        {
            Hashtable varTable = new Hashtable();
            varTable.Add("x", x.ToString());

            return (float)parser.Parse(equation, varTable);
        }

        public override string ToString()
        {
            return "y=" + this.equation;
        }
    }
}
