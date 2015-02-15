using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshViewer
{
    class STriangle
    {
        public SPoint[] points = new SPoint[3];

        public String triangleName = "Triangle";

        public STriangle()
        {
            for (int i = 0; i < 4; i++) points[i] = new SPoint(0, 0, 0);
        }

        public STriangle(SPoint v0, SPoint v1, SPoint v2)
        {
            points[0] = v0;
            points[1] = v1;
            points[2] = v2;
        }

        public STriangle transform(SMatrix matrix)
        {
            STriangle transformedTri = new STriangle();

            for (int i = 0; i < 3; i++)
            {
                transformedTri.points[i] = points[i].Transform(matrix);
                transformedTri.points[i] = transformedTri.points[i].Rescale();
            }
            return transformedTri;
        }

        public void draw(Graphics g)
        {
            Pen pen = new Pen(Color.Black, 1);

            for (int i = 0; i < 3; i++)     // Draw the three lines as a loop.
                g.DrawLine(pen,
                    (int)points[i].point[0], (int)points[i].point[1],
                    (int)points[i + 1].point[0], (int)points[i + 1].point[1]);

            //And back to the first point for the last line.
            g.DrawLine(pen,
                (int)points[3].point[0], (int)points[3].point[1],
                (int)points[0].point[0], (int)points[0].point[1]);

        }
        public void drawAsFilledPolygon(Graphics g)
        {
            Pen pen = new Pen(Color.Blue, 1);   //Not needed.

            Color brushColour = Color.FromArgb(255, 0, 0); //Red, but pass as a parameter.
            SolidBrush brush = new SolidBrush(brushColour);

            //Construct an array of .net points to draw.

            Point[] netPoints = new Point[3];
            netPoints[0] = new Point((int)points[0].point[0], (int)points[0].point[1]);
            netPoints[1] = new Point((int)points[1].point[0], (int)points[1].point[1]);
            netPoints[2] = new Point((int)points[2].point[0], (int)points[2].point[1]);

            g.FillPolygon(brush, netPoints);
        }
    }
}
