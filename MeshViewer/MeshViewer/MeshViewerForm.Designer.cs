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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.gbRotation = new System.Windows.Forms.GroupBox();
            this.gbScale = new System.Windows.Forms.GroupBox();
            this.gbPerspective = new System.Windows.Forms.GroupBox();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.gbPerspective.SuspendLayout();
            this.SuspendLayout();
            // 
            // vsbFocalLength
            // 
            this.vsbFocalLength.Location = new System.Drawing.Point(27, 61);
            this.vsbFocalLength.Maximum = 900;
            this.vsbFocalLength.Minimum = 10;
            this.vsbFocalLength.Name = "vsbFocalLength";
            this.vsbFocalLength.Size = new System.Drawing.Size(30, 120);
            this.vsbFocalLength.TabIndex = 0;
            this.vsbFocalLength.Value = 400;
            this.vsbFocalLength.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbFocalLength_Scroll);
            // 
            // vsbX
            // 
            this.vsbX.Location = new System.Drawing.Point(17, 48);
            this.vsbX.Maximum = 500;
            this.vsbX.Name = "vsbX";
            this.vsbX.Size = new System.Drawing.Size(30, 120);
            this.vsbX.TabIndex = 2;
            this.vsbX.Value = 50;
            this.vsbX.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbX_Scroll);
            // 
            // vsbZ
            // 
            this.vsbZ.Location = new System.Drawing.Point(129, 48);
            this.vsbZ.Maximum = 800;
            this.vsbZ.Minimum = 20;
            this.vsbZ.Name = "vsbZ";
            this.vsbZ.Size = new System.Drawing.Size(30, 120);
            this.vsbZ.TabIndex = 4;
            this.vsbZ.Value = 400;
            this.vsbZ.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vsbZ_Scroll);
            // 
            // lblFocal
            // 
            this.lblFocal.AutoSize = true;
            this.lblFocal.Location = new System.Drawing.Point(14, 24);
            this.lblFocal.Name = "lblFocal";
            this.lblFocal.Size = new System.Drawing.Size(69, 13);
            this.lblFocal.TabIndex = 3;
            this.lblFocal.Text = "Focal Length";
            this.lblFocal.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZAxis
            // 
            this.lblZAxis.AutoSize = true;
            this.lblZAxis.Location = new System.Drawing.Point(126, 24);
            this.lblZAxis.Name = "lblZAxis";
            this.lblZAxis.Size = new System.Drawing.Size(14, 13);
            this.lblZAxis.TabIndex = 4;
            this.lblZAxis.Text = "Z";
            this.lblZAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblXAxis
            // 
            this.lblXAxis.AutoSize = true;
            this.lblXAxis.Location = new System.Drawing.Point(14, 24);
            this.lblXAxis.Name = "lblXAxis";
            this.lblXAxis.Size = new System.Drawing.Size(14, 13);
            this.lblXAxis.TabIndex = 5;
            this.lblXAxis.Text = "X";
            this.lblXAxis.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblFocalValue
            // 
            this.lblFocalValue.AutoSize = true;
            this.lblFocalValue.Location = new System.Drawing.Point(35, 48);
            this.lblFocalValue.Name = "lblFocalValue";
            this.lblFocalValue.Size = new System.Drawing.Size(13, 13);
            this.lblFocalValue.TabIndex = 6;
            this.lblFocalValue.Text = "0";
            this.lblFocalValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblZValue
            // 
            this.lblZValue.AutoSize = true;
            this.lblZValue.Location = new System.Drawing.Point(146, 24);
            this.lblZValue.Name = "lblZValue";
            this.lblZValue.Size = new System.Drawing.Size(13, 13);
            this.lblZValue.TabIndex = 7;
            this.lblZValue.Text = "0";
            this.lblZValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblMatrixDisplay
            // 
            this.lblMatrixDisplay.AutoSize = true;
            this.lblMatrixDisplay.Location = new System.Drawing.Point(12, 504);
            this.lblMatrixDisplay.Name = "lblMatrixDisplay";
            this.lblMatrixDisplay.Size = new System.Drawing.Size(35, 13);
            this.lblMatrixDisplay.TabIndex = 8;
            this.lblMatrixDisplay.Text = "Matrix";
            // 
            // lblXValue
            // 
            this.lblXValue.AutoSize = true;
            this.lblXValue.Location = new System.Drawing.Point(32, 24);
            this.lblXValue.Name = "lblXValue";
            this.lblXValue.Size = new System.Drawing.Size(13, 13);
            this.lblXValue.TabIndex = 9;
            this.lblXValue.Text = "0";
            this.lblXValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnShowPoints
            // 
            this.btnShowPoints.Location = new System.Drawing.Point(12, 478);
            this.btnShowPoints.Name = "btnShowPoints";
            this.btnShowPoints.Size = new System.Drawing.Size(75, 23);
            this.btnShowPoints.TabIndex = 10;
            this.btnShowPoints.Text = "Show points";
            this.btnShowPoints.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.openToolStripMenuItem.Text = "Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.openToolStripMenuItem_Click_1);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblXValue);
            this.groupBox1.Controls.Add(this.lblZValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.lblZAxis);
            this.groupBox1.Controls.Add(this.vsbX);
            this.groupBox1.Controls.Add(this.vScrollBar1);
            this.groupBox1.Controls.Add(this.vsbZ);
            this.groupBox1.Controls.Add(this.lblXAxis);
            this.groupBox1.Location = new System.Drawing.Point(592, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(180, 180);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Translation";
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Location = new System.Drawing.Point(71, 48);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(30, 120);
            this.vScrollBar1.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "0";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(70, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Y";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gbRotation
            // 
            this.gbRotation.Location = new System.Drawing.Point(592, 224);
            this.gbRotation.Name = "gbRotation";
            this.gbRotation.Size = new System.Drawing.Size(180, 180);
            this.gbRotation.TabIndex = 13;
            this.gbRotation.TabStop = false;
            this.gbRotation.Text = "Rotation";
            // 
            // gbScale
            // 
            this.gbScale.Location = new System.Drawing.Point(592, 410);
            this.gbScale.Name = "gbScale";
            this.gbScale.Size = new System.Drawing.Size(180, 180);
            this.gbScale.TabIndex = 14;
            this.gbScale.TabStop = false;
            this.gbScale.Text = "Scale";
            // 
            // gbPerspective
            // 
            this.gbPerspective.Controls.Add(this.vsbFocalLength);
            this.gbPerspective.Controls.Add(this.lblFocal);
            this.gbPerspective.Controls.Add(this.lblFocalValue);
            this.gbPerspective.Location = new System.Drawing.Point(497, 397);
            this.gbPerspective.Name = "gbPerspective";
            this.gbPerspective.Size = new System.Drawing.Size(89, 193);
            this.gbPerspective.TabIndex = 15;
            this.gbPerspective.TabStop = false;
            this.gbPerspective.Text = "Perspective";
            this.gbPerspective.Enter += new System.EventHandler(this.gbPerspective_Enter);
            // 
            // MeshViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 601);
            this.Controls.Add(this.gbPerspective);
            this.Controls.Add(this.gbScale);
            this.Controls.Add(this.gbRotation);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnShowPoints);
            this.Controls.Add(this.lblMatrixDisplay);
            this.Controls.Add(this.menuStrip1);
            this.Name = "MeshViewer";
            this.Text = "Mesh Viewer";
            this.Load += new System.EventHandler(this.MeshViewer_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.MeshViewer_Paint);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gbPerspective.ResumeLayout(false);
            this.gbPerspective.PerformLayout();
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
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.GroupBox gbRotation;
        private System.Windows.Forms.GroupBox gbScale;
        private System.Windows.Forms.GroupBox gbPerspective;
    }
}

