using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshViewer
{
    class SMatrix
    {
        public double[,] matrix = new double[4, 4];
        public double[,] material;
        public String matrixName = "Matrix";
        public int rows, cols;
        
        public SMatrix(int pRows, int pCols)
        {
            rows = pRows;
            cols = pCols;
            material = new double[rows, cols];
        }

        public static SMatrix ZeroMatrix(int pRows, int pCols)
        {
            SMatrix m = new SMatrix(pRows, pCols);

            for(int i = 0; i < pRows; i++)
            {
                for(int j = 0; j < pCols; j++)
                {
                    m.matrix[i, j] = 0;
                }
            }

            return m;
        }

        public static SMatrix IdentityMatrix(int pRows, int pCols)
        {
            SMatrix m = ZeroMatrix(pRows, pCols);
            for (int i = 0; i < Math.Min(pRows, pCols); i++)
            {
                m.matrix[i, i] = 1;
            }
            return m;
        }

        public static SMatrix ScalingMatrix(double sx, double sy, double sz)
        {
            SMatrix m = IdentityMatrix(4, 4);
            for (int i = 0; i < Math.Min(4, 4); i++)
            {
                if (i == 0)
                    m.matrix[i, i] = sx;

                else if (i == 1)
                    m.matrix[i, i] = sy;

                else if (i == 2)
                    m.matrix[i, i] = sz;

                else
                    m.matrix[i, i] = 1;
            }
            return m;
        }

        public static SMatrix RotateAboutX(double rot)
        {
            SMatrix m = ZeroMatrix(4, 4);

            m.matrix[1, 1] = Math.Cos(rot);
            m.matrix[1, 2] = Math.Sin(rot);
            m.matrix[2, 1] = -(Math.Sin(rot));
            m.matrix[2, 2] = Math.Cos(rot);
            return m;
        }

        public static SMatrix RotateAboutY(double rot)
        {
            SMatrix m = ZeroMatrix(4, 4);

            m.matrix[0, 2] = -1 * rot;
            m.matrix[1, 1] = 1 * rot;
            m.matrix[2, 0] = 1 * rot;
            m.matrix[3, 3] = 1;

            return m;
        }
        public static SMatrix RotateAboutZ(double rot)
        {
            SMatrix m = ZeroMatrix(4, 4);

            m.matrix[0, 1] = 1 * rot;
            m.matrix[1, 0] = -1 * rot;
            m.matrix[2, 2] = 1 * rot;
            m.matrix[3, 3] = 1;

            return m;
        }

        public static SMatrix RotateAboutOrigin(double x, double y)
        {
            SMatrix m = ZeroMatrix(3, 3);

            m.matrix[0, 1] = 1 * x;
            m.matrix[1, 0] = -1 * y;
            m.matrix[2, 2] = 1;

            return m;
        }
        //problem
        public static SMatrix TranslationMatrix(int tx, int ty, int tz)
        {
            SMatrix m = IdentityMatrix(4, 4);
            m.matrix[0, 0] = 1;         //Now all we need do is insert//
            m.matrix[1, 1] = 1;         //the non-zeros.              //
            m.matrix[2, 2] = 1;
            m.matrix[3, 3] = 1;
            m.matrix[0, 3] = tx; m.matrix[1, 3] = ty; m.matrix[2, 3] = tz;
            return m;
        }

        public static SMatrix PerspectiveMatrix(double f)
        {
            SMatrix m = IdentityMatrix(4, 4);
            m.matrix[3, 2] = 1 / f;
            m.matrix[0, 0] = 1; m.matrix[1, 1] = 1; m.matrix[2, 2] = 1;
            m.matrix[3, 3] = 0;

            return m;
        }

        public static SMatrix CreatePerspective(double fov, double aspectRatio, double zNear, double zFar)
        {
            SMatrix m = ZeroMatrix(4, 4);
            const double piOver360 = 0.0087266;
            double xyMax, xMin, yMin, width, height, depth, q, qn, w, h;

            xyMax = zNear * Math.Tan(fov * piOver360);
            yMin = -xyMax;
            xMin = -xyMax;

            width = xyMax - xMin;
            height = xyMax - yMin;

            depth = zFar - zNear;
            q = -(zFar * zNear) / depth;
            qn = -2 * (zFar * zNear) / depth;

            w = 2 * zNear / width;
            w = w / aspectRatio;
            h = 2 * zNear / height;

            m.matrix[0, 1] = w;
            m.matrix[1, 1] = h;
            m.matrix[2, 2] = q;
            m.matrix[2, 3] = -1;
            m.matrix[3, 2] = qn;

            return m;
        }

        private static SMatrix Multiply(SMatrix A, SMatrix B)
        {
            if (A.cols != B.rows) throw new Exception("SMatrix A # of columns does not match SMatrix B # of rows");

            SMatrix R;

            int msize = Math.Max(Math.Max(A.rows, A.cols), Math.Max(B.rows, B.cols));

            if (msize < 32)
            {
                R = ZeroMatrix(A.rows,B.cols);
                for (int i = 0; i < R.rows; i++)
                    for (int j = 0; j < R.cols; j++)
                        for (int k = 0; k < A.cols; k++)
                            R.matrix[j, i] += A.matrix[k, i] * B.matrix[j, k];

                return R;
            }

            return null;
        }

        public override string ToString()
        {
            string s = "";
            int temp = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    temp++;
                    s += String.Format("{0,5:0.00}", matrix[i, j]) + " ";
                    if (temp == rows)
                    {
                        s += "\r\n";
                        temp = 0;
                    }
                }
            }
            return s;
        }

        public static SMatrix operator *(SMatrix m1, SMatrix m2)
        { return SMatrix.Multiply(m1, m2); }
    }
}
