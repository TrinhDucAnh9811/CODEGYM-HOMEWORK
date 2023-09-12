using System;
namespace DucAnh
{
    class Point2D
    {
        public float x = 0.0f;
        public float y = 0.0f;

        public Point2D (float x, float y)
        {
            this.x = x;
            this.y = y;
        }

        public Point2D() { }

        public void SetX(float x) { this.x = x;}
        public float GetX() { return x; }

        public void SetY(float y) { this.y = y; }
        public float GetY() { return y; }

        public void SetXY(float x, float y)
        {
            this.x = x;
            this.y = y;
        }
        public float[] GetXY()
        {
            return new float[2] {x,y};
        }

        public override string ToString()
        {
            return "Point2D " + x + ", " + y ;
        }
    }
}