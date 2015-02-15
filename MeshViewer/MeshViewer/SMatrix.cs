using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeshViewer
{
    class SMatrix
    {
        public double[,] mat = new double[4, 4];
        public String matrixName = "Matrix";
        public int rows, cols;
        
        public SMatrix(int pRows, int pCols)
        {
            rows = pRows;
            cols = pCols;
            mat = new double[rows, cols];
        }

        public double this[int pRows, int pCols]      // Access this matrix as a 2D array
        {
            get { return mat[pRows, pCols]; }
            set { mat[pRows, pCols] = value; }
        }

        public static SMatrix ZeroMatrix(int pRows, int pCols)
        {
            SMatrix m = new SMatrix(pRows, pCols);

            for(int i = 0; i < pRows; i++)
            {
                for(int j = 0; j < pCols; j++)
                {
                    m[i, j] = 0;
                }
            }

            return m;
        }



        public static SMatrix IdentityMatrix(int pRows, int pCols)
        {
            SMatrix m = ZeroMatrix(pRows, pCols);
            for (int i = 0; i < Math.Min(pRows, pCols); i++)
            {
                m[i, i] = 1;
            }
            return m;
        }

        public static SMatrix ScalingMatrix(double sx, double sy, double sz)
        {
            SMatrix m = IdentityMatrix(4, 4);
            m.matrixName = "scale";
            for (int i = 0; i < Math.Min(4, 4); i++)
            {
                if (i == 0)
                    m[i, i] = sx;

                else if (i == 1)
                    m[i, i] = sy;

                else if (i == 2)
                    m[i, i] = sz;

                else
                    m[i, i] = 1;
            }
            return m;
        }

        public static SMatrix RotateAboutX(double rot)
        {
            SMatrix m = IdentityMatrix(4, 4);

            m[1, 1] = Math.Cos(rot);
            m[1, 2] = Math.Sin(rot);
            m[2, 1] = -(Math.Sin(rot));
            m[2, 2] = Math.Cos(rot);
            return m;
        }

        public static SMatrix RotateAboutY(double rot)
        {
            SMatrix m = IdentityMatrix(4, 4);

            m[0, 0] = Math.Cos(rot);
            m[0, 2] = -(Math.Sin(rot));
            m[2, 0] = Math.Sin(rot);
            m[2, 2] = Math.Cos(rot);
            return m;
        }
        public static SMatrix RotateAboutZ(double rot)
        {
            SMatrix m = IdentityMatrix(4, 4);

            m[0, 0] = Math.Cos(rot);
            m[0, 1] = Math.Sin(rot);
            m[1, 0] = -(Math.Sin(rot));
            m[1, 1] = Math.Cos(rot);

            return m;
        }

        public static SMatrix RotateAboutOrigin(double x, double y)
        {
            SMatrix m = IdentityMatrix(3, 3);

            m[0, 1] = 1 * x;
            m[1, 0] = -1 * y;
            m[2, 2] = 1;

            return m;
        }
        //problem
        public static SMatrix TranslationMatrix(int tx, int ty, int tz)
        {
            SMatrix m = IdentityMatrix(4, 4);
            m.matrixName = "translation";
            m[0, 0] = 1;         //Now all we need do is insert//
            m[1, 1] = 1;         //the non-zeros.              //
            m[2, 2] = 1;
            m[3, 3] = 1;
            m[0, 3] = tx; m[1, 3] = ty; m[2, 3] = tz;
            return m;
        }

        public static SMatrix PerspectiveMatrix(double f)
        {
            SMatrix m = IdentityMatrix(4, 4);
            m.matrixName = "perspective";
            m[3, 2] = 1 / f;
            m[3, 3] = 0;
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

            m[0, 1] = w;
            m[1, 1] = h;
            m[2, 2] = q;
            m[2, 3] = -1;
            m[3, 2] = qn;

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
                            R[j, i] += A[k, i] * B[j, k];

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
                    s += String.Format("{0,5:0.00}", mat[i, j]) + " ";
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
