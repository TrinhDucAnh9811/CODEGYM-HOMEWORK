using System;
namespace DucAnh
{
    class Point3D : Point2D
    {
        public float z = 0.0f;

        public Point3D (float x, float y, float z) : base(x,y)
        {
            this.z = z;
        }

        public Point3D() { }

        public float GetZ()
        { return z; }

        public void SetZ(float z)
        {
            this.z = z;
        }

        public void SetXYZ(float x, float y, float z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public float[] GetXYZ()
        {
            return new float[3] {x,y,z};
        }

        public override string ToString()
        {
            return "Point3D " + x + ", " + y + ", " + z;
        }
    }
}