using System.Drawing;

public class FlippedPointF
{
    public float X { get; set; }
    public float Y { get; set; }

    public FlippedPointF(float x, float y)
    { 
        this.X = x;
        this.Y = y; 
    }

    public PointF toPoint()
    {
        return new PointF(this.X, -this.Y);
    }
}