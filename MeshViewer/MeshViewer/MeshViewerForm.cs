using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeshViewer
{
    public partial class MeshViewer : Form
    {
        SMatrix scalingMatrix;
        SMatrix translationMatrix;
        SMatrix rotationXMatrix;
        SMatrix perspectiveMatrix;
        SMatrix WVPMatrix;
        SQuad[] cube = new SQuad[6];

        public MeshViewer()
        {
            InitializeComponent();
        }

        private void MeshViewer_Load(object sender, EventArgs e)
        {
            
        }

        private void MeshViewer_Paint(object sender, PaintEventArgs e)
        {
            LoadMesh();
            TransformMesh();
            DrawMesh();
            UpdateGUI();
        }

        private void LoadMesh()
        {
            SPoint p0, p1, p2, p3;

            perspectiveMatrix = SMatrix.PerspectiveMatrix(vsbFocalLength.Value);
            translationMatrix = SMatrix.TranslationMatrix(vsbX.Value, 50, vsbZ.Value);
            scalingMatrix = SMatrix.ScalingMatrix(100, 100, 100);

            rotationXMatrix = SMatrix.RotateAboutX(90);

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
                WVPMatrix = scalingMatrix * translationMatrix * perspectiveMatrix;
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
                MessageBox.Show(ofd.FileName);
            }
        }
        
    }
}
