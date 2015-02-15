using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshViewer
{
    class SPoint
    {
        public SPoint()
        {
            for (int i = 0; i < 3; i++) point[i] = 0; point[3] = 1;
        }

        public SPoint(double x, double y, double z)
        {
            point[0] = x; point[1] = y; point[2] = z; point[3] = 1;
        }

        public SPoint(String name)
        {
            for (int i = 0; i < 3; i++) point[i] = 0; point[3] = 1;
            pointName = name;
        }

        public double[] point = new double[4];
        public String pointName = "Point";

        public SPoint Transform(SMatrix matrix)
        {    
            double total;
            SPoint newPoint = new SPoint(pointName);

            for (int col = 0; col < 4; col++)
            {
                total = 0;
                for (int row = 0; row < 4; row++)
                    total = total + point[row] * matrix[col, row];

                newPoint.point[col] = total;
            }

            return newPoint;   
        }

        public SPoint Rescale()
        {
            SPoint newPoint = new SPoint(pointName);
            for (int i = 0; i < 4; i++)
                newPoint.point[i] = point[i] / point[3];

            return newPoint;
        }

        public override string ToString()
        {
 	        String s = pointName + ": ";

            for (int i = 0; i < 4; i++)
            {
                s += Convert.ToString(point[i] + " ");
            }

            return s;
        }

    }
}
