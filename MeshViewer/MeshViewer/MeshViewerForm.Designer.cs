namespace MeshViewer
{
    partial class MeshViewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.vsbFocalLength = new System.Windows.Forms.VScrollBar();
            this.vsbX = new System.Windows.Forms.VScrollBar();
            this.vsbZ = new System.Windows.Forms.VScrollBar();
            this.lblFocal = new System.Windows.Forms.Label();
            this.lblZAxis = new System.Windows.Forms.Label();
            this.lblXAxis = new System.Windows.Forms.Label();
            this.lblFocalValue = new System.Windows.Forms.Label();
            this.lblZValue = new System.Windows.Forms.Label();
            this.lblMatrixDisplay = new System.Windows.Forms.Label();
            this.lblXValue = new System.Windows.Forms.Label();
            this.btnShowPoints = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // vsbFocalLength
            // 
            this.vsbFocalLength.Location = new System.Drawing.Point(424, 93);
            this.vsbFocalLength.Maximum = 900;
            this.vsbFocalLength.Minimum = 10;
            this.vsbFocalLength.Name = "vsbFocalLength";
            this.vsbFocalLength.Size = new System.Drawing.Size(35, 272);
            this.vsbFocalLength.TabIndex = 0;
            this.vsbFocalLength.Value = 400;
            this.vsbFocalLength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbFocalLength_Scroll);
            // 
            // vsbX
            // 
            this.vsbX.Location = new System.Drawing.Point(482, 93);
            this.vsbX.Maximum = 500;
            this.vsbX.Name = "vsbX";
            this.vsbX.Size = new System.Drawing.Size(35, 272);
            this.vsbX.TabIndex = 2;
            this.vsbX.Value = 50;
            this.vsbX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbX_Scroll);
            // 
            // vsbZ
            // 
            this.vsbZ.Location = new System.Drawing.Point(537, 93);
            this.vsbZ.Maximum = 800;
            this.vsbZ.Minimum = 20;
            this.vsbZ.Name = "vsbZ";
            this.vsbZ.Size = new System.Drawing.Size(37, 272);
            this.vsbZ.TabIndex = 4;
            this.vsbZ.Value = 400;
            this.vsbZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbZ_Scroll);
            // 
            // lblFocal
            // 
            this.lblFocal.AutoSize = true;
            this.lblFocal.Location = new System.Drawing.Point(434, 30);
            this.lblFocal.Name = "lblFocal";
            this.lblFocal.Size = new System.Drawing.Size(13, 13);
            this.lblFocal.TabIndex = 3;
            this.lblFocal.Text = "F";
            this.lblFocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZAxis
            // 
            this.lblZAxis.AutoSize = true;
            this.lblZAxis.Location = new System.Drawing.Point(548, 30);
            this.lblZAxis.Name = "lblZAxis";
            this.lblZAxis.Size = new System.Drawing.Size(14, 13);
            this.lblZAxis.TabIndex = 4;
            this.lblZAxis.Text = "Z";
            this.lblZAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXAxis
            // 
            this.lblXAxis.AutoSize = true;
            this.lblXAxis.Location = new System.Drawing.Point(493, 30);
            this.lblXAxis.Name = "lblXAxis";
            this.lblXAxis.Size = new System.Drawing.Size(14, 13);
            this.lblXAxis.TabIndex = 5;
            this.lblXAxis.Text = "X";
            this.lblXAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFocalValue
            // 
            this.lblFocalValue.AutoSize = true;
            this.lblFocalValue.Location = new System.Drawing.Point(434, 80);
            this.lblFocalValue.Name = "lblFocalValue";
            this.lblFocalValue.Size = new System.Drawing.Size(13, 13);
            this.lblFocalValue.TabIndex = 6;
            this.lblFocalValue.Text = "0";
            this.lblFocalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZValue
            // 
            this.lblZValue.AutoSize = true;
            this.lblZValue.Location = new System.Drawing.Point(549, 80);
            this.lblZValue.Name = "lblZValue";
            this.lblZValue.Size = new System.Drawing.Size(13, 13);
            this.lblZValue.TabIndex = 7;
            this.lblZValue.Text = "0";
            this.lblZValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrixDisplay
            // 
            this.lblMatrixDisplay.AutoSize = true;
            this.lblMatrixDisplay.Location = new System.Drawing.Point(482, 459);
            this.lblMatrixDisplay.Name = "lblMatrixDisplay";
            this.lblMatrixDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblMatrixDisplay.TabIndex = 8;
            this.lblMatrixDisplay.Text = "Matrix";
            // 
            // lblXValue
            // 
            this.lblXValue.AutoSize = true;
            this.lblXValue.Location = new System.Drawing.Point(494, 80);
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Size = new System.Drawing.Size(13, 13);
            this.lblXValue.TabIndex = 9;
            this.lblXValue.Text = "0";
            this.lblXValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowPoints
            // 
            this.btnShowPoints.Location = new System.Drawing.Point(466, 407);
            this.btnShowPoints.Name = "btnShowPoints";
            this.btnShowPoints.Size = new System.Drawing.Size(75, 23);
            this.btnShowPoints.TabIndex = 10;
            this.btnShowPoints.Text = "Show points";
            this.btnShowPoints.UseVisualStyleBackColor = true;
            // 
            // MeshViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(606, 516);
            this.Controls.Add(this.btnShowPoints);
            this.Controls.Add(this.lblXValue);
            this.Controls.Add(this.lblMatrixDisplay);
            this.Controls.Add(this.lblZValue);
            this.Controls.Add(this.lblFocalValue);
            this.Controls.Add(this.lblXAxis);
            this.Controls.Add(this.lblZAxis);
            this.Controls.Add(this.lblFocal);
            this.Controls.Add(this.vsbZ);
            this.Controls.Add(this.vsbX);
            this.Controls.Add(this.vsbFocalLength);
            this.Name = "MeshViewer";
            this.Text = "Mesh Viewer";
            this.Load += new System.EventHandler(this.MeshViewer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MeshViewer_Paint);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.VScrollBar vsbFocalLength;
        private System.Windows.Forms.VScrollBar vsbX;
        private System.Windows.Forms.VScrollBar vsbZ;
        private System.Windows.Forms.Label lblFocal;
        private System.Windows.Forms.Label lblZAxis;
        private System.Windows.Forms.Label lblXAxis;
        private System.Windows.Forms.Label lblFocalValue;
        private System.Windows.Forms.Label lblZValue;
        private System.Windows.Forms.Label lblMatrixDisplay;
        private System.Windows.Forms.Label lblXValue;
        private System.Windows.Forms.Button btnShowPoints;
    }
}

