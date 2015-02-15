using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace MeshViewer
{
    public partial class MeshViewer : Form
    {
        SMatrix scalingMatrix;
        SMatrix translationMatrix;
        SMatrix rotationXMatrix, rotationYMatrix, rotationZMatrix;
        SMatrix perspectiveMatrix;
        SMatrix WVPMatrix;
        SQuad[] cube = new SQuad[6], mesh;
        STriangle[] triangles;
        bool loaded = false;
        double rotSpeed = 1.01;

        StreamReader sr;

        struct Vertex
        {
            public double x, y, z;
        }

        Vertex[] vertices;

        public MeshViewer()
        {
            InitializeComponent();
        }

        private void MeshViewer_Load(object sender, EventArgs e)
        {
            string s = "";
            //Create matrices
            SPoint p1 = new SPoint();
            cube[0] = new SQuad(new SPoint(1,2,3), new SPoint(3,2,1), new SPoint(1,2,3), new SPoint(3,2,1));
            scalingMatrix = SMatrix.ScalingMatrix(3, 3, 3);
            rotationXMatrix = SMatrix.RotateAboutX(20);
            translationMatrix = SMatrix.TranslationMatrix(1,100,1);
            perspectiveMatrix = SMatrix.PerspectiveMatrix(50);
            WVPMatrix = scalingMatrix * rotationXMatrix * translationMatrix * perspectiveMatrix;

            cube[0] = cube[0].transform(WVPMatrix);
            
            //cube[0] = cube[0].transform(SMatrix.ScalingMatrix(3, 3, 3));
            //cube[0] = cube[0].transform(SMatrix.TranslationMatrix(10, 100, 1));
            //cube[0] = cube[0].transform(SMatrix.PerspectiveMatrix(50));
            for (int i = 0; i < 4; i++)
            {
                s += cube[0].points[i].ToString() +"\n";
            }

            lblMatrixDisplay.Text = s;
            //Test point scale, translation, perspective
        }

        private void MeshViewer_Paint(object sender, PaintEventArgs e)
        {
            if (loaded)
            {
                LoadMesh();
                TransformMesh();
                DrawMesh();
                UpdateGUI();
            }
        }

        private void LoadMesh()
        {
            SPoint p0, p1, p2, p3;
            
            perspectiveMatrix = SMatrix.PerspectiveMatrix(vsbFocalLength.Value);
            translationMatrix = SMatrix.TranslationMatrix(vsbX.Value, 300, vsbZ.Value);
            scalingMatrix = SMatrix.ScalingMatrix(100, 100, 100);
            rotationXMatrix = SMatrix.RotateAboutX(5);
   
            rotationYMatrix = SMatrix.RotateAboutY(20);
            rotationZMatrix = SMatrix.RotateAboutZ(20);

            p0 = new SPoint(0, 0, 0); p1 = new SPoint(0, 1, 0);   //Create front face//
            p2 = new SPoint(1, 1, 0); p3 = new SPoint(1, 0, 0);   //of my cube.....  //
            cube[0] = new SQuad(p0, p1, p2, p3);

            p0 = new SPoint(0, 0, 1); p1 = new SPoint(0, 1, 1);   //Create back face  //
            p2 = new SPoint(1, 1, 1); p3 = new SPoint(1, 0, 1);   //of my cube.....   //
            cube[1] = new SQuad(p0, p1, p2, p3);

            p0 = new SPoint(0, 0, 1); p1 = new SPoint(0, 1, 1);   //Create top face  //
            p2 = new SPoint(1, 1, 1); p3 = new SPoint(1, 0, 1);   //of my cube.....  //
            cube[2] = new SQuad(p0, p1, p2, p3);

            p0 = new SPoint(0, 0, 0); p1 = new SPoint(1, 0, 0);   //Create bottom    //
            p2 = new SPoint(1, 0, 1); p3 = new SPoint(0, 0, 1);   //of my cube.....  //
            cube[3] = new SQuad(p0, p1, p2, p3);

            p0 = new SPoint(0, 0, 0); p1 = new SPoint(0, 1, 0);   //Create left face of//
            p2 = new SPoint(0, 1, 1); p3 = new SPoint(0, 0, 1);   //of my cube.....    //
            cube[4] = new SQuad(p0, p1, p2, p3);

            p0 = new SPoint(1, 0, 0); p1 = new SPoint(1, 1, 0);   //Create right face of//
            p2 = new SPoint(1, 1, 1); p3 = new SPoint(1, 0, 1);   //of my cube.....    //
            cube[5] = new SQuad(p0, p1, p2, p3);
        }

        private void TransformMesh()
        {
            for (int i = 0; i < cube.Length; i++)
            {
                //WVPMatrix = scalingMatrix * translationMatrix * perspectiveMatrix;
                //mesh[i] = mesh[i].transform(WVPMatrix);
                WVPMatrix = scalingMatrix * rotationYMatrix * translationMatrix * perspectiveMatrix;
                cube[i] = cube[i].transform(WVPMatrix);
                lblMatrixDisplay.Text = WVPMatrix.ToString();
            }
        }

        private void DrawMesh()
        {
            Graphics g = CreateGraphics();

            for (int i = 0; i < cube.Length; i++)
            {
                //Uncomment the line below what you are ready to do the depth //
                //sort, it draws the cobe as a filled polygon.                //

                //cube[i].drawAsFilledPolygon(g);
                cube[i].draw(g);
                //mesh[i].draw(g);
            }
        }

        private void UpdateGUI()
        {
            lblFocalValue.Text = Convert.ToString(vsbFocalLength.Value);
            lblXValue.Text = Convert.ToString(vsbX.Value);
            lblZValue.Text = Convert.ToString(vsbZ.Value);
        }

        private void vsbFocalLength_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void vsbX_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void vsbZ_Scroll(object sender, ScrollEventArgs e)
        {
            Invalidate();
        }

        private void openToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text file|*.txt";

            if(ofd.ShowDialog() == DialogResult.OK)
            {
                sr = new StreamReader(ofd.FileName);
            }

            int numVerts = Convert.ToInt32(sr.ReadLine());

            Console.WriteLine(numVerts);

            vertices = new Vertex[numVerts];

            for(int i = 0; i < numVerts; i++)
            {
                double x, y, z;
                String xyz = sr.ReadLine().TrimStart();
                String[] strVertices = xyz.Split(' ');

                x = Convert.ToDouble(strVertices[0]);
                y = Convert.ToDouble(strVertices[1]);
                z = Convert.ToDouble(strVertices[2]);

                vertices[i].x = x;
                vertices[i].y = y;
                vertices[i].z = z;
            }

            String numTriangles = sr.ReadLine();
            int tris = Convert.ToInt32(numTriangles);
            //mesh = new STriangle[tris];
            triangles = new STriangle[tris];

            Console.WriteLine("Number of triangles: " + tris);

            int n, index1, index2, index3;
            SPoint p1, p2, p3;

            for(int i = 0; i < tris; i++)
            {
                String indexes = sr.ReadLine().TrimStart();
                String[] strTris = indexes.Split(' ');

                n = Convert.ToInt32(strTris[0]);
                index1 = Convert.ToInt32(strTris[1]);
                index2 = Convert.ToInt32(strTris[2]);
                index3 = Convert.ToInt32(strTris[3]);

                p1 = new SPoint(vertices[index1].x, vertices[index1].y, vertices[index1].z);
                p2 = new SPoint(vertices[index2].x, vertices[index2].y, vertices[index2].z);
                p3 = new SPoint(vertices[index3].x, vertices[index3].y, vertices[index3].z);

                triangles[i] = new STriangle(p1, p2, p3);               
            }

            mesh = new SQuad[triangles.Length];
            mesh[0] = new SQuad(triangles[0]);
            mesh[1] = new SQuad(triangles[1]);
            mesh[2] = new SQuad(triangles[2]);
            mesh[3] = new SQuad(triangles[3]);
            mesh[4] = new SQuad(triangles[4]);
            Console.WriteLine(triangles[0].points[0].ToString());
            //mesh[0].InsertTriangle(triangles[0]);
            //mesh[1].InsertTriangle(triangles[1]);
            //mesh[2].InsertTriangle(triangles[2]);
            //mesh[3].InsertTriangle(triangles[3]);
            //mesh[4].InsertTriangle(triangles[4]);
            //mesh[5].InsertTriangle(triangles[5]);

            loaded = true;

        }

        private void gbPerspective_Enter(object sender, EventArgs e)
        {

        }
        
    }
}
